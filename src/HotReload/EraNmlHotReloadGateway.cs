using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using EraWheel.Core.Logging;
using HarmonyLib;
using Mono.Cecil;
using Mono.Cecil.Cil;
using NeoModLoader.api;
using NeoModLoader.constants;
using NeoModLoader.utils.Builders;

namespace EraWheel.HotReload;

public static class EraNmlHotReloadGateway
{
    private static readonly BindingFlags AnyStatic = BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;
    private static readonly BindingFlags AnyMethod = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;

    public static bool TryPrepareAndCompile(
        IReloadable mod,
        ModDeclare declaration,
        out EraCompiledReloadAssembly? compiled,
        out string message
    )
    {
        compiled = null;
        Type? reloadUtilsType = AccessTools.TypeByName("NeoModLoader.utils.ModReloadUtils");
        if (reloadUtilsType == null)
        {
            message = "编译失败：未找到 NeoModLoader.utils.ModReloadUtils。";
            return false;
        }

        if (!InvokeReloadUtilsBool(reloadUtilsType, "Prepare", mod, declaration))
        {
            message = "编译失败：ModReloadUtils.Prepare 返回 false。请先确认该 MOD 已经有一份可用的已编译 DLL。";
            return false;
        }

        if (!InvokeReloadUtilsBool(reloadUtilsType, "CompileNew"))
        {
            message = "编译失败：NeoModLoader 运行时编译返回 false。";
            return false;
        }

        string newDllPath = ResolveCompiledDllPath(reloadUtilsType, declaration);
        string newPdbPath = ResolveCompiledPdbPath(reloadUtilsType, declaration);
        string oldDllPath = $"{newDllPath}.bak";
        string oldPdbPath = $"{newPdbPath}.bak";
        if (!File.Exists(newDllPath))
        {
            message = $"编译失败：找不到新 DLL：{newDllPath}";
            return false;
        }

        if (!File.Exists(oldDllPath))
        {
            message = $"编译失败：找不到旧 DLL 快照：{oldDllPath}";
            return false;
        }

        compiled = new EraCompiledReloadAssembly(newDllPath, oldDllPath, newPdbPath, oldPdbPath);
        message = $"编译完成：new={Path.GetFileName(newDllPath)} old={Path.GetFileName(oldDllPath)}。";
        return true;
    }

    public static bool TryScanCompatibility(
        Assembly runtimeAssembly,
        EraCompiledReloadAssembly compiled,
        out EraCompatibilityReport report,
        out string message
    )
    {
        report = new EraCompatibilityReport();
        try
        {
            using AssemblyDefinition oldAssembly = ReadAssembly(compiled.OldAssemblyPath);
            using AssemblyDefinition newAssembly = ReadAssembly(compiled.NewAssemblyPath);
            Dictionary<string, TypeDefinition> oldTypes = CollectEraTypes(oldAssembly);
            Dictionary<string, TypeDefinition> newTypes = CollectEraTypes(newAssembly);

            AddMissingTypeIssues(oldTypes.Keys.Except(newTypes.Keys, StringComparer.Ordinal), EraCompatibilityIssueKind.RemovedType, report);
            AddMissingTypeIssues(newTypes.Keys.Except(oldTypes.Keys, StringComparer.Ordinal), EraCompatibilityIssueKind.AddedType, report);

            foreach ((string typeKey, TypeDefinition oldType) in oldTypes)
            {
                if (!newTypes.TryGetValue(typeKey, out TypeDefinition? newType))
                {
                    continue;
                }

                ScanFields(typeKey, oldType, newType, report);
                ScanMethods(runtimeAssembly, typeKey, oldType, newType, report);
            }

            message = report.CreateSummary();
            return true;
        }
        catch (Exception exception)
        {
            report.Issues.Add(
                new EraCompatibilityIssue
                {
                    Kind = EraCompatibilityIssueKind.RuntimeMethodMissing,
                    Member = "compatibility_scan",
                    Message = $"兼容扫描本身失败：{exception.Message}",
                }
            );
            message = report.CreateSummary();
            EraLog.Exception(EraLogCategory.Debug, "热加载兼容扫描失败。", exception);
            return false;
        }
    }

    public static bool TryPatchChangedMethods(
        Assembly runtimeAssembly,
        EraCompiledReloadAssembly compiled,
        out EraMethodPatchReport report,
        out string message
    )
    {
        report = new EraMethodPatchReport();
        Type? reloadUtilsType = AccessTools.TypeByName("NeoModLoader.utils.ModReloadUtils");
        MethodInfo? replaceMethod = reloadUtilsType?.GetMethod("Replace", AnyStatic);
        MethodInfo? hotfixMethod = reloadUtilsType?.GetMethod("HotfixMethod", AnyStatic);
        if (reloadUtilsType == null || (replaceMethod == null && hotfixMethod == null))
        {
            message = "方法体补丁失败：找不到 NeoModLoader 的 Replace/HotfixMethod 私有入口。";
            return false;
        }

        try
        {
            using AssemblyDefinition oldAssembly = ReadAssembly(compiled.OldAssemblyPath);
            using AssemblyDefinition newAssembly = ReadAssembly(compiled.NewAssemblyPath);
            Dictionary<string, MethodDefinition> oldMethods = CollectEraMethods(oldAssembly)
                .ToDictionary(GetMethodKey, StringComparer.Ordinal);
            List<MethodDefinition> newMethods = CollectEraMethods(newAssembly)
                .Where(IsPatchableMethod)
                .ToList();
            Harmony harmony = new Harmony($"{runtimeAssembly.GetName().Name}.EraWheelSafeHotReload");

            foreach (MethodDefinition newMethod in newMethods)
            {
                string methodKey = GetMethodKey(newMethod);
                if (!oldMethods.TryGetValue(methodKey, out MethodDefinition? oldMethod) ||
                    !MethodBodyChanged(oldMethod, newMethod))
                {
                    report.Skipped++;
                    continue;
                }

                Type? runtimeType = ResolveRuntimeType(runtimeAssembly, newMethod.DeclaringType);
                MethodBase? runtimeMethod = runtimeType == null ? null : ResolveRuntimeMethod(runtimeType, newMethod);
                if (runtimeMethod is not MethodInfo runtimeMethodInfo)
                {
                    report.Failed++;
                    report.FailureMessages.Add($"找不到运行时方法：{newMethod.FullName}");
                    continue;
                }

                try
                {
                    InvokePatchMethod(replaceMethod, hotfixMethod, harmony, runtimeMethodInfo, newMethod);
                    report.Patched++;
                    report.PatchedMethodKeys.Add(methodKey);
                }
                catch (Exception exception)
                {
                    report.Failed++;
                    string error = exception.InnerException?.Message ?? exception.Message;
                    report.FailureMessages.Add($"{newMethod.FullName}: {error}");
                    EraLog.Warning(EraLogCategory.Debug, $"方法体补丁失败：{newMethod.FullName} -> {error}");
                }
            }

            message = report.FailureMessages.Count == 0
                ? report.CreateSummary()
                : $"{report.CreateSummary()} 失败项：{string.Join(" | ", report.FailureMessages.Take(4))}";
            return report.Failed == 0;
        }
        catch (Exception exception)
        {
            message = $"方法体补丁失败：{exception.Message}";
            EraLog.Exception(EraLogCategory.Debug, "方法体补丁失败。", exception);
            return false;
        }
    }

    public static bool TryRollbackPatchedMethods(
        Assembly runtimeAssembly,
        EraCompiledReloadAssembly compiled,
        IReadOnlyList<string> methodKeys,
        out string message
    )
    {
        if (methodKeys.Count == 0)
        {
            message = "反向方法补丁跳过：本次没有成功替换的方法体。";
            return true;
        }

        Type? reloadUtilsType = AccessTools.TypeByName("NeoModLoader.utils.ModReloadUtils");
        MethodInfo? replaceMethod = reloadUtilsType?.GetMethod("Replace", AnyStatic);
        MethodInfo? hotfixMethod = reloadUtilsType?.GetMethod("HotfixMethod", AnyStatic);
        if (reloadUtilsType == null || (replaceMethod == null && hotfixMethod == null))
        {
            message = "反向方法补丁失败：找不到 NeoModLoader 的 Replace/HotfixMethod 私有入口。";
            return false;
        }

        try
        {
            using AssemblyDefinition oldAssembly = ReadAssembly(compiled.OldAssemblyPath);
            Dictionary<string, MethodDefinition> oldMethods = CollectEraMethods(oldAssembly)
                .Where(IsPatchableMethod)
                .ToDictionary(GetMethodKey, StringComparer.Ordinal);
            HashSet<string> rollbackKeys = new HashSet<string>(methodKeys, StringComparer.Ordinal);
            Harmony harmony = new Harmony($"{runtimeAssembly.GetName().Name}.EraWheelSafeHotReloadRollback");
            int restored = 0;
            List<string> failures = new List<string>();

            foreach (string methodKey in rollbackKeys)
            {
                if (!oldMethods.TryGetValue(methodKey, out MethodDefinition? oldMethod))
                {
                    failures.Add($"旧 DLL 缺少方法：{methodKey}");
                    continue;
                }

                Type? runtimeType = ResolveRuntimeType(runtimeAssembly, oldMethod.DeclaringType);
                MethodBase? runtimeMethod = runtimeType == null ? null : ResolveRuntimeMethod(runtimeType, oldMethod);
                if (runtimeMethod is not MethodInfo runtimeMethodInfo)
                {
                    failures.Add($"运行时方法缺失：{oldMethod.FullName}");
                    continue;
                }

                try
                {
                    InvokePatchMethod(replaceMethod, hotfixMethod, harmony, runtimeMethodInfo, oldMethod);
                    restored++;
                }
                catch (Exception exception)
                {
                    failures.Add($"{oldMethod.FullName}: {exception.InnerException?.Message ?? exception.Message}");
                }
            }

            message = failures.Count == 0
                ? $"反向方法补丁完成：restored={restored}。"
                : $"反向方法补丁存在失败：restored={restored} failed={failures.Count}；{string.Join(" | ", failures.Take(4))}";
            return failures.Count == 0;
        }
        catch (Exception exception)
        {
            message = $"反向方法补丁失败：{exception.Message}";
            EraLog.Exception(EraLogCategory.Debug, "反向方法补丁失败。", exception);
            return false;
        }
    }

    public static bool TryReloadResources(IMod mod, out string message)
    {
        try
        {
            Type? resourcesPatchType = AccessTools.TypeByName("NeoModLoader.utils.ResourcesPatch");
            MethodInfo? loadResourceMethod = resourcesPatchType?.GetMethod("LoadResourceFromFolder", AnyStatic);
            if (resourcesPatchType == null || loadResourceMethod == null)
            {
                message = "资源重载失败：找不到 NeoModLoader.utils.ResourcesPatch.LoadResourceFromFolder。";
                return false;
            }

            MasterBuilder masterBuilder = new MasterBuilder();
            string root = mod.GetDeclaration().FolderPath;
            object?[] resourceArgs =
            {
                Path.Combine(root, Paths.ModResourceFolderName),
                null,
            };
            object?[] additionArgs =
            {
                Path.Combine(root, Paths.NCMSAdditionModResourceFolderName),
                null,
            };
            loadResourceMethod.Invoke(null, resourceArgs);
            loadResourceMethod.Invoke(null, additionArgs);

            if (resourceArgs[1] is IEnumerable<Builder> builders)
            {
                masterBuilder.AddBuilders(builders);
            }

            if (additionArgs[1] is IEnumerable<Builder> additionBuilders)
            {
                masterBuilder.AddBuilders(additionBuilders);
            }

            masterBuilder.BuildAll();
            message = "NeoModLoader 资源重载成功。";
            return true;
        }
        catch (Exception exception)
        {
            message = $"资源重载失败：{exception.Message}";
            EraLog.Exception(EraLogCategory.Data, "资源重载失败。", exception);
            return false;
        }
    }

    public static void ReloadLocales(IMod mod, out int reloadedFiles)
    {
        reloadedFiles = 0;
        try
        {
            Type? serviceType = AccessTools.TypeByName("NeoModLoader.services.ModReloadService");
            MethodInfo? reloadLocales = serviceType?.GetMethod("ReloadLocales", AnyStatic);
            reloadLocales?.Invoke(null, new object[] { mod });

            string localeDir = (mod as ILocalizable)?.GetLocaleFilesDirectory(mod.GetDeclaration())
                ?? Path.Combine(mod.GetDeclaration().FolderPath, "Locales");
            if (Directory.Exists(localeDir))
            {
                reloadedFiles = Directory.GetFiles(localeDir, "*.json", SearchOption.TopDirectoryOnly).Length;
            }
        }
        catch (Exception exception)
        {
            EraLog.Exception(EraLogCategory.Localization, "文本重载失败。", exception);
        }
    }

    private static void AddMissingTypeIssues(
        IEnumerable<string> typeKeys,
        EraCompatibilityIssueKind kind,
        EraCompatibilityReport report
    )
    {
        foreach (string typeKey in typeKeys)
        {
            report.Issues.Add(
                new EraCompatibilityIssue
                {
                    Kind = kind,
                    Member = typeKey,
                    Message = kind == EraCompatibilityIssueKind.AddedType
                        ? "新增类型不能安全注入当前已加载程序集。"
                        : "删除类型会让旧运行态引用失效。",
                }
            );
        }
    }

    private static void ScanFields(
        string typeKey,
        TypeDefinition oldType,
        TypeDefinition newType,
        EraCompatibilityReport report
    )
    {
        Dictionary<string, FieldDefinition> oldFields = oldType.Fields.ToDictionary(field => field.Name, StringComparer.Ordinal);
        Dictionary<string, FieldDefinition> newFields = newType.Fields.ToDictionary(field => field.Name, StringComparer.Ordinal);
        foreach (string fieldName in oldFields.Keys.Except(newFields.Keys, StringComparer.Ordinal))
        {
            report.Issues.Add(
                new EraCompatibilityIssue
                {
                    Kind = EraCompatibilityIssueKind.RemovedField,
                    Member = $"{typeKey}.{fieldName}",
                    Message = "删除字段会改变旧对象内存布局，需要重启。",
                }
            );
        }

        foreach (string fieldName in newFields.Keys.Except(oldFields.Keys, StringComparer.Ordinal))
        {
            report.Issues.Add(
                new EraCompatibilityIssue
                {
                    Kind = EraCompatibilityIssueKind.AddedField,
                    Member = $"{typeKey}.{fieldName}",
                    Message = "新增字段不会出现在已加载的旧类型里，需要重启。",
                }
            );
        }

        foreach ((string fieldName, FieldDefinition oldField) in oldFields)
        {
            if (!newFields.TryGetValue(fieldName, out FieldDefinition? newField))
            {
                continue;
            }

            if (!string.Equals(GetFieldShape(oldField), GetFieldShape(newField), StringComparison.Ordinal))
            {
                report.Issues.Add(
                    new EraCompatibilityIssue
                    {
                        Kind = EraCompatibilityIssueKind.ChangedField,
                        Member = $"{typeKey}.{fieldName}",
                        Message = "字段类型或静态/实例属性发生变化，需要重启。",
                    }
                );
            }
        }
    }

    private static void ScanMethods(
        Assembly runtimeAssembly,
        string typeKey,
        TypeDefinition oldType,
        TypeDefinition newType,
        EraCompatibilityReport report
    )
    {
        Dictionary<string, MethodDefinition> oldMethods = oldType.Methods.ToDictionary(GetMethodKey, StringComparer.Ordinal);
        Dictionary<string, MethodDefinition> newMethods = newType.Methods.ToDictionary(GetMethodKey, StringComparer.Ordinal);

        foreach (string methodKey in oldMethods.Keys.Except(newMethods.Keys, StringComparer.Ordinal))
        {
            EraCompatibilityIssueKind kind = oldMethods[methodKey].IsConstructor
                ? EraCompatibilityIssueKind.ConstructorChanged
                : EraCompatibilityIssueKind.RemovedMethodSignature;
            report.Issues.Add(
                new EraCompatibilityIssue
                {
                    Kind = kind,
                    Member = methodKey,
                    Message = oldMethods[methodKey].IsConstructor
                        ? "构造器签名被删除或改变，需要重启。"
                        : "方法签名被删除或改变，需要重启。",
                }
            );
        }

        foreach (string methodKey in newMethods.Keys.Except(oldMethods.Keys, StringComparer.Ordinal))
        {
            EraCompatibilityIssueKind kind = newMethods[methodKey].IsConstructor
                ? EraCompatibilityIssueKind.ConstructorChanged
                : EraCompatibilityIssueKind.AddedMethodSignature;
            report.Issues.Add(
                new EraCompatibilityIssue
                {
                    Kind = kind,
                    Member = methodKey,
                    Message = newMethods[methodKey].IsConstructor
                        ? "构造器签名被新增或改变，需要重启。"
                        : "新增方法签名不能安全注入旧程序集，需要重启。",
                }
            );
        }

        foreach ((string methodKey, MethodDefinition oldMethod) in oldMethods)
        {
            if (!newMethods.TryGetValue(methodKey, out MethodDefinition? newMethod))
            {
                continue;
            }

            if (oldMethod.IsConstructor && MethodBodyChanged(oldMethod, newMethod))
            {
                report.Issues.Add(
                    new EraCompatibilityIssue
                    {
                        Kind = oldMethod.IsStatic
                            ? EraCompatibilityIssueKind.StaticInitializerChanged
                            : EraCompatibilityIssueKind.ConstructorChanged,
                        Member = methodKey,
                        Message = oldMethod.IsStatic
                            ? "静态初始化逻辑已经运行过，不能安全热替换。"
                            : "构造器逻辑变化只会影响新对象，旧对象无法补齐，需要重启。",
                    }
                );
                continue;
            }

            if (!IsPatchableMethod(newMethod) || !MethodBodyChanged(oldMethod, newMethod))
            {
                continue;
            }

            Type? runtimeType = ResolveRuntimeType(runtimeAssembly, newMethod.DeclaringType);
            MethodBase? runtimeMethod = runtimeType == null ? null : ResolveRuntimeMethod(runtimeType, newMethod);
            if (runtimeMethod is not MethodInfo)
            {
                report.Issues.Add(
                    new EraCompatibilityIssue
                    {
                        Kind = EraCompatibilityIssueKind.RuntimeMethodMissing,
                        Member = methodKey,
                        Message = $"运行时找不到可替换的方法体，类型={typeKey}。",
                    }
                );
            }
        }
    }

    private static Dictionary<string, TypeDefinition> CollectEraTypes(AssemblyDefinition assembly)
    {
        return CollectAllTypes(assembly.MainModule.Types)
            .Where(IsEraWheelType)
            .ToDictionary(type => type.FullName, StringComparer.Ordinal);
    }

    private static List<TypeDefinition> CollectAllTypes(IEnumerable<TypeDefinition> roots)
    {
        List<TypeDefinition> types = new List<TypeDefinition>();
        foreach (TypeDefinition type in roots)
        {
            types.Add(type);
            if (type.HasNestedTypes)
            {
                types.AddRange(CollectAllTypes(type.NestedTypes));
            }
        }

        return types;
    }

    private static List<MethodDefinition> CollectEraMethods(AssemblyDefinition assembly)
    {
        return CollectAllTypes(assembly.MainModule.Types)
            .Where(IsEraWheelType)
            .SelectMany(type => type.Methods)
            .ToList();
    }

    private static bool IsEraWheelType(TypeDefinition type)
    {
        return !string.IsNullOrWhiteSpace(type.Namespace) &&
               type.Namespace.StartsWith("EraWheel", StringComparison.Ordinal);
    }

    private static bool IsPatchableMethod(MethodDefinition method)
    {
        return method.HasBody &&
               !method.IsConstructor &&
               !method.IsAbstract &&
               !method.IsPInvokeImpl;
    }

    private static string GetMethodKey(MethodDefinition method)
    {
        return method.FullName;
    }

    private static string GetFieldShape(FieldDefinition field)
    {
        return $"{field.FieldType.FullName}|static={field.IsStatic}|literal={field.IsLiteral}|readonly={field.IsInitOnly}";
    }

    private static bool MethodBodyChanged(MethodDefinition oldMethod, MethodDefinition newMethod)
    {
        if (oldMethod.HasBody != newMethod.HasBody)
        {
            return true;
        }

        if (!oldMethod.HasBody)
        {
            return false;
        }

        return !string.Equals(CreateBodyFingerprint(oldMethod), CreateBodyFingerprint(newMethod), StringComparison.Ordinal);
    }

    private static string CreateBodyFingerprint(MethodDefinition method)
    {
        if (!method.HasBody)
        {
            return string.Empty;
        }

        StringBuilder builder = new StringBuilder();
        builder.Append("vars:");
        foreach (VariableDefinition variable in method.Body.Variables)
        {
            builder.Append(variable.VariableType.FullName).Append(';');
        }

        builder.Append("|il:");
        foreach (Instruction instruction in method.Body.Instructions)
        {
            builder.Append(instruction.OpCode.Code).Append(' ').Append(NormalizeOperand(method, instruction)).Append(';');
        }

        builder.Append("|eh:");
        foreach (ExceptionHandler handler in method.Body.ExceptionHandlers)
        {
            builder
                .Append(handler.HandlerType)
                .Append(':')
                .Append(handler.CatchType?.FullName ?? string.Empty)
                .Append(':')
                .Append(GetInstructionIndex(method, handler.TryStart))
                .Append('-')
                .Append(GetInstructionIndex(method, handler.TryEnd))
                .Append(':')
                .Append(GetInstructionIndex(method, handler.HandlerStart))
                .Append('-')
                .Append(GetInstructionIndex(method, handler.HandlerEnd))
                .Append(';');
        }

        return builder.ToString();
    }

    private static string NormalizeOperand(MethodDefinition method, Instruction instruction)
    {
        object? operand = instruction.Operand;
        return operand switch
        {
            null => string.Empty,
            Instruction target => $"IL#{GetInstructionIndex(method, target) - GetInstructionIndex(method, instruction)}",
            Instruction[] targets => string.Join(",", targets.Select(target => GetInstructionIndex(method, target) - GetInstructionIndex(method, instruction))),
            MethodReference methodReference => methodReference.FullName,
            FieldReference fieldReference => fieldReference.FullName,
            TypeReference typeReference => typeReference.FullName,
            ParameterDefinition parameter => $"P{parameter.Index}:{parameter.ParameterType.FullName}",
            VariableDefinition variable => $"V{variable.Index}:{variable.VariableType.FullName}",
            string text => text,
            _ => operand.ToString() ?? string.Empty,
        };
    }

    private static int GetInstructionIndex(MethodDefinition method, Instruction? target)
    {
        if (target == null || !method.HasBody)
        {
            return -1;
        }

        for (int index = 0; index < method.Body.Instructions.Count; index++)
        {
            if (ReferenceEquals(method.Body.Instructions[index], target))
            {
                return index;
            }
        }

        return -1;
    }

    private static Type? ResolveRuntimeType(Assembly runtimeAssembly, TypeDefinition typeDefinition)
    {
        string fullName = typeDefinition.FullName;
        return runtimeAssembly.GetType(fullName)
            ?? runtimeAssembly.GetType(fullName.Replace('/', '+'))
            ?? AccessTools.TypeByName(fullName)
            ?? AccessTools.TypeByName(fullName.Replace('/', '+'));
    }

    private static MethodBase? ResolveRuntimeMethod(Type runtimeType, MethodDefinition methodDefinition)
    {
        if (methodDefinition.IsConstructor)
        {
            return runtimeType
                .GetConstructors(AnyMethod)
                .FirstOrDefault(candidate => ParametersMatch(candidate.GetParameters(), methodDefinition.Parameters));
        }

        return runtimeType
            .GetMethods(AnyMethod)
            .Where(candidate => candidate.Name == methodDefinition.Name)
            .Where(candidate => candidate.GetGenericArguments().Length == methodDefinition.GenericParameters.Count)
            .FirstOrDefault(candidate => ParametersMatch(candidate.GetParameters(), methodDefinition.Parameters));
    }

    private static bool ParametersMatch(ParameterInfo[] runtimeParameters, Mono.Collections.Generic.Collection<ParameterDefinition> cecilParameters)
    {
        if (runtimeParameters.Length != cecilParameters.Count)
        {
            return false;
        }

        for (int index = 0; index < runtimeParameters.Length; index++)
        {
            if (!ParameterTypeMatches(runtimeParameters[index].ParameterType, cecilParameters[index].ParameterType))
            {
                return false;
            }
        }

        return true;
    }

    private static bool ParameterTypeMatches(Type runtimeType, TypeReference cecilType)
    {
        bool runtimeByRef = runtimeType.IsByRef;
        bool cecilByRef = cecilType is ByReferenceType;
        if (runtimeByRef != cecilByRef)
        {
            return false;
        }

        Type runtimeCore = runtimeByRef ? runtimeType.GetElementType() ?? runtimeType : runtimeType;
        TypeReference cecilCore = cecilByRef ? ((ByReferenceType)cecilType).ElementType : cecilType;
        if (runtimeCore.IsGenericParameter || cecilCore is GenericParameter)
        {
            return true;
        }

        string runtimeFullName = runtimeCore.FullName ?? runtimeCore.Name;
        string cecilFullName = cecilCore.FullName;
        return string.Equals(runtimeFullName, cecilFullName, StringComparison.Ordinal) ||
               string.Equals(runtimeFullName.Replace('+', '/'), cecilFullName, StringComparison.Ordinal) ||
               string.Equals(NormalizeTypeName(runtimeFullName), NormalizeTypeName(cecilFullName), StringComparison.Ordinal);
    }

    private static string NormalizeTypeName(string value)
    {
        string current = value.Replace('+', '/');
        int genericMark = current.IndexOf('`');
        if (genericMark >= 0)
        {
            current = current.Substring(0, genericMark);
        }

        int bracketMark = current.IndexOf('[');
        if (bracketMark >= 0)
        {
            current = current.Substring(0, bracketMark);
        }

        int angleMark = current.IndexOf('<');
        if (angleMark >= 0)
        {
            current = current.Substring(0, angleMark);
        }

        return current.EndsWith("&", StringComparison.Ordinal)
            ? current.Substring(0, current.Length - 1).Trim()
            : current.Trim();
    }

    private static void InvokePatchMethod(
        MethodInfo? replaceMethod,
        MethodInfo? hotfixMethod,
        Harmony harmony,
        MethodInfo runtimeMethod,
        MethodDefinition methodDefinition
    )
    {
        if (replaceMethod != null)
        {
            replaceMethod.Invoke(null, new object[] { runtimeMethod, methodDefinition });
            return;
        }

        hotfixMethod!.Invoke(null, new object[] { harmony, methodDefinition, runtimeMethod });
    }

    private static AssemblyDefinition ReadAssembly(string path)
    {
        byte[] bytes = File.ReadAllBytes(path);
        return AssemblyDefinition.ReadAssembly(new MemoryStream(bytes));
    }

    private static bool InvokeReloadUtilsBool(Type reloadUtilsType, string methodName, params object[] arguments)
    {
        MethodInfo? method = reloadUtilsType.GetMethod(methodName, AnyStatic);
        if (method == null)
        {
            return false;
        }

        try
        {
            object? result = method.Invoke(null, arguments);
            return result as bool? ?? false;
        }
        catch (Exception exception)
        {
            EraLog.Exception(EraLogCategory.Debug, $"调用 ModReloadUtils.{methodName} 失败。", exception);
            return false;
        }
    }

    private static string ResolveCompiledDllPath(Type reloadUtilsType, ModDeclare declaration)
    {
        FieldInfo? pathField = reloadUtilsType.GetField("_new_compiled_dll_path", AnyStatic);
        string? fromField = pathField?.GetValue(null) as string;
        return !string.IsNullOrWhiteSpace(fromField)
            ? fromField
            : Path.Combine(Paths.CompiledModsPath, $"{declaration.UID}.dll");
    }

    private static string ResolveCompiledPdbPath(Type reloadUtilsType, ModDeclare declaration)
    {
        FieldInfo? pathField = reloadUtilsType.GetField("_new_compiled_pdb_path", AnyStatic);
        string? fromField = pathField?.GetValue(null) as string;
        return !string.IsNullOrWhiteSpace(fromField)
            ? fromField
            : Path.Combine(Paths.CompiledModsPath, $"{declaration.UID}.pdb");
    }
}
