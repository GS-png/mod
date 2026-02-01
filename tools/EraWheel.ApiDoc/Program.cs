using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

internal static class Program
{
    private const BindingFlags MemberFlags = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly;

    private static readonly Dictionary<Type, string> TypeAliases = new Dictionary<Type, string>
    {
        { typeof(void), "void" },
        { typeof(bool), "bool" },
        { typeof(byte), "byte" },
        { typeof(sbyte), "sbyte" },
        { typeof(short), "short" },
        { typeof(ushort), "ushort" },
        { typeof(int), "int" },
        { typeof(uint), "uint" },
        { typeof(long), "long" },
        { typeof(ulong), "ulong" },
        { typeof(float), "float" },
        { typeof(double), "double" },
        { typeof(decimal), "decimal" },
        { typeof(char), "char" },
        { typeof(string), "string" },
        { typeof(object), "object" }
    };

    private static readonly Dictionary<string, string> TypeAliasNames = new Dictionary<string, string>(StringComparer.Ordinal)
    {
        { "System.Void", "void" },
        { "System.Boolean", "bool" },
        { "System.Byte", "byte" },
        { "System.SByte", "sbyte" },
        { "System.Int16", "short" },
        { "System.UInt16", "ushort" },
        { "System.Int32", "int" },
        { "System.UInt32", "uint" },
        { "System.Int64", "long" },
        { "System.UInt64", "ulong" },
        { "System.Single", "float" },
        { "System.Double", "double" },
        { "System.Decimal", "decimal" },
        { "System.Char", "char" },
        { "System.String", "string" },
        { "System.Object", "object" }
    };

    private static readonly string[] DefaultDlls =
    {
        "Assembly-CSharp.dll",
        "NeoModLoader.dll",
        "UnityEngine.CoreModule.dll",
        "UnityEngine.IMGUIModule.dll",
        "UnityEngine.JSONSerializeModule.dll",
        "UnityEngine.UI.dll",
        "UnityEngine.UIModule.dll",
        "UnityEngine.TextRenderingModule.dll",
        "UnityEngine.InputLegacyModule.dll"
    };

    private static int Main(string[] args)
    {
        var options = Options.Parse(args);
        if (options.ShowHelp || !options.IsValid)
        {
            PrintUsage(options.ErrorMessage);
            return options.IsValid ? 0 : 1;
        }

        var libDir = Path.GetFullPath(options.LibDir);
        var outputPath = Path.GetFullPath(options.OutputPath);

        if (!Directory.Exists(libDir))
        {
            Console.Error.WriteLine("Lib directory not found: " + libDir);
            return 1;
        }

        var warnings = new WarningBag();
        foreach (var warning in options.Warnings)
        {
            warnings.AddWarning(warning);
        }

        var assemblyPaths = ResolveAssemblyPaths(libDir, options.IncludeDlls, options.IncludeAll, warnings);
        if (assemblyPaths.Count == 0)
        {
            Console.Error.WriteLine("No assemblies found in: " + libDir);
            return 1;
        }

        var assemblyNameMap = Directory.GetFiles(libDir, "*.dll")
            .ToDictionary(path => Path.GetFileNameWithoutExtension(path), path => path, StringComparer.OrdinalIgnoreCase);
        AppDomain.CurrentDomain.AssemblyResolve += (_, eventArgs) =>
        {
            var name = new AssemblyName(eventArgs.Name).Name;
            if (name != null && assemblyNameMap.TryGetValue(name, out var candidate) && File.Exists(candidate))
            {
                try
                {
                    return Assembly.LoadFrom(candidate);
                }
                catch
                {
                    return null;
                }
            }
            return null;
        };

        var assemblies = new List<AssemblyEntry>();
        foreach (var path in assemblyPaths)
        {
            var entry = LoadAssembly(path, warnings);
            if (entry != null)
            {
                assemblies.Add(entry);
            }
        }

        var outputDir = Path.GetDirectoryName(outputPath);
        if (!string.IsNullOrEmpty(outputDir))
        {
            Directory.CreateDirectory(outputDir);
        }

        WriteMarkdown(outputPath, libDir, assemblies, warnings, options.SplitByAssembly);

        var allWarnings = warnings.GetAllWarnings();
        Console.WriteLine("API doc generated: " + outputPath);
        if (allWarnings.Count > 0)
        {
            Console.WriteLine("Warnings:");
            foreach (var warning in allWarnings)
            {
                Console.WriteLine("- " + warning);
            }
        }

        return 0;
    }

    private static void PrintUsage(string errorMessage)
    {
        if (!string.IsNullOrWhiteSpace(errorMessage))
        {
            Console.Error.WriteLine(errorMessage);
        }

        Console.WriteLine("Usage: dotnet run --project tools/EraWheel.ApiDoc/EraWheel.ApiDoc.csproj -- [options]");
        Console.WriteLine("Options:");
        Console.WriteLine("  --lib <dir>    Source dll directory (default: tools/WorldBox.Managed)");
        Console.WriteLine("  --out <file>   Output markdown file (default: docs/api/index.md)");
        Console.WriteLine("  --dll <name>   Include a specific dll (repeatable)");
        Console.WriteLine("  --all          Include all dlls in lib directory");
        Console.WriteLine("  --single       Output single file (do not split)");
        Console.WriteLine("  --help         Show help");
        Console.WriteLine("Default dlls: " + string.Join(", ", DefaultDlls));
    }

    private static List<string> ResolveAssemblyPaths(string libDir, List<string> includeDlls, bool includeAll, WarningBag warnings)
    {
        var paths = new List<string>();
        if (includeAll && includeDlls.Count == 0)
        {
            paths.AddRange(Directory.GetFiles(libDir, "*.dll"));
        }
        else if (includeDlls.Count > 0)
        {
            foreach (var dllName in includeDlls)
            {
                var candidate = dllName;
                if (!candidate.EndsWith(".dll", StringComparison.OrdinalIgnoreCase))
                {
                    candidate += ".dll";
                }

                if (!Path.IsPathRooted(candidate))
                {
                    candidate = Path.Combine(libDir, candidate);
                }

                if (!File.Exists(candidate))
                {
                    warnings.AddWarning("Missing dll: " + candidate);
                    continue;
                }

                paths.Add(Path.GetFullPath(candidate));
            }
        }
        else
        {
            paths.AddRange(Directory.GetFiles(libDir, "*.dll"));
        }

        return paths.OrderBy(path => Path.GetFileName(path), StringComparer.OrdinalIgnoreCase).ToList();
    }

    private static AssemblyEntry LoadAssembly(string path, WarningBag warnings)
    {
        Assembly assembly;
        try
        {
            assembly = Assembly.LoadFrom(path);
        }
        catch (Exception ex)
        {
            warnings.AddWarning($"Failed to load {path}: {ex.GetType().Name} {ex.Message}");
            return null;
        }

        Type[] types;
        try
        {
            types = assembly.GetTypes();
        }
        catch (ReflectionTypeLoadException ex)
        {
            types = ex.Types.Where(type => type != null).ToArray();
            if (ex.LoaderExceptions != null)
            {
                foreach (var loaderException in ex.LoaderExceptions)
                {
                    if (loaderException != null)
                    {
                        if (loaderException is FileNotFoundException || loaderException is FileLoadException)
                        {
                            warnings.AddMissing(loaderException);
                        }
                        else
                        {
                            warnings.AddWarning($"Type load warning in {path}: {loaderException.GetType().Name} {loaderException.Message}");
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            warnings.AddWarning($"Failed to read types from {path}: {ex.GetType().Name} {ex.Message}");
            return null;
        }

        var name = assembly.GetName().Name;
        if (string.IsNullOrWhiteSpace(name))
        {
            name = Path.GetFileNameWithoutExtension(path);
        }

        return new AssemblyEntry(name, path, types.Where(type => type != null).ToList());
    }

    private static void WriteMarkdown(string outputPath, string libDir, List<AssemblyEntry> assemblies, WarningBag warnings, bool splitByAssembly)
    {
        var orderedAssemblies = assemblies
            .OrderBy(entry => entry.Name, StringComparer.OrdinalIgnoreCase)
            .ToList();

        var outputDir = Path.GetDirectoryName(outputPath);
        if (!string.IsNullOrEmpty(outputDir))
        {
            Directory.CreateDirectory(outputDir);
        }

        if (splitByAssembly)
        {
            foreach (var assembly in orderedAssemblies)
            {
                var fileName = GetAssemblyFileName(assembly.Name);
                var assemblyPath = string.IsNullOrEmpty(outputDir) ? fileName : Path.Combine(outputDir, fileName);
                WriteAssemblyFile(assemblyPath, assembly, warnings);
            }
        }

        using var writer = new StreamWriter(outputPath, false, new UTF8Encoding(false));
        writer.WriteLine("# EraWheel API Index");
        writer.WriteLine();
        writer.WriteLine("Generated: " + DateTime.UtcNow.ToString("u", CultureInfo.InvariantCulture).TrimEnd());
        writer.WriteLine("Source: " + libDir);
        writer.WriteLine("Assemblies: " + orderedAssemblies.Count.ToString(CultureInfo.InvariantCulture));
        writer.WriteLine();
        writer.WriteLine("## Assembly List");

        foreach (var assembly in orderedAssemblies)
        {
            var typeCount = assembly.Types.Count.ToString(CultureInfo.InvariantCulture);
            if (splitByAssembly)
            {
                var fileName = GetAssemblyFileName(assembly.Name);
                writer.WriteLine($"- [{assembly.Name}]({fileName}) (Types: {typeCount})");
            }
            else
            {
                writer.WriteLine($"- {assembly.Name} (Types: {typeCount})");
            }
        }

        writer.WriteLine();

        if (!splitByAssembly)
        {
            foreach (var assembly in orderedAssemblies)
            {
                WriteAssemblyContent(writer, assembly, warnings, 2);
            }
        }

        var allWarnings = warnings.GetAllWarnings();
        if (allWarnings.Count > 0)
        {
            writer.WriteLine("## Warnings");
            writer.WriteLine();
            foreach (var warning in allWarnings)
            {
                writer.WriteLine("- " + warning);
            }
        }
    }

    private static void WriteAssemblyFile(string outputPath, AssemblyEntry assembly, WarningBag warnings)
    {
        using var writer = new StreamWriter(outputPath, false, new UTF8Encoding(false));
        WriteAssemblyContent(writer, assembly, warnings, 1);
    }

    private static void WriteAssemblyContent(StreamWriter writer, AssemblyEntry assembly, WarningBag warnings, int assemblyHeadingLevel)
    {
        writer.WriteLine(GetHeadingPrefix(assemblyHeadingLevel) + " Assembly: " + assembly.Name);
        writer.WriteLine("- Path: " + ToRelativePath(assembly.Path));
        writer.WriteLine("- Types: " + assembly.Types.Count.ToString(CultureInfo.InvariantCulture));
        writer.WriteLine();

        var typeEntries = assembly.Types
            .Select(type => TypeEntry.TryCreate(type, warnings))
            .Where(entry => entry != null)
            .ToList();

        var namespaceGroups = typeEntries
            .OrderBy(entry => entry.Namespace, StringComparer.OrdinalIgnoreCase)
            .ThenBy(entry => entry.Name, StringComparer.OrdinalIgnoreCase)
            .GroupBy(entry => entry.Namespace);

        var namespaceHeadingLevel = assemblyHeadingLevel + 1;
        var typeHeadingLevel = assemblyHeadingLevel + 2;
        var memberHeadingLevel = assemblyHeadingLevel + 3;

        foreach (var nsGroup in namespaceGroups)
        {
            writer.WriteLine(GetHeadingPrefix(namespaceHeadingLevel) + " Namespace: " + nsGroup.Key);
            writer.WriteLine();

            foreach (var entry in nsGroup.OrderBy(item => item.Name, StringComparer.OrdinalIgnoreCase))
            {
                WriteType(writer, entry.Type, warnings, typeHeadingLevel, memberHeadingLevel);
            }
        }
    }

    private static void WriteType(StreamWriter writer, Type type, WarningBag warnings, int typeHeadingLevel, int memberHeadingLevel)
    {
        try
        {
            var access = GetAccessModifier(type);
            var kind = GetTypeKind(type);
            var name = GetTypeDisplayName(type, true);
            var modifiers = new List<string> { access };

            if (type.IsClass && type.IsAbstract && type.IsSealed)
            {
                modifiers.Add("static");
            }

            writer.WriteLine(GetHeadingPrefix(typeHeadingLevel) + " " + string.Join(" ", modifiers) + " " + kind + " " + name);

            var baseType = type.BaseType;
            if (baseType != null && baseType != typeof(object) && !type.IsEnum && !type.IsInterface && !type.IsValueType)
            {
                writer.WriteLine("- Base: " + GetTypeDisplayName(baseType, true));
            }

            var interfaces = SafeGetMembers(() => type.GetInterfaces(), warnings, type, "interfaces");
            if (interfaces.Length > 0)
            {
                writer.WriteLine("- Interfaces: " + string.Join(", ", interfaces.Select(item => GetTypeDisplayName(item, true))));
            }

            writer.WriteLine();

            if (type.IsEnum)
            {
                var values = SafeGetMembers(() => type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static), warnings, type, "enum values")
                    .Where(field => field.IsLiteral && !field.IsSpecialName)
                    .OrderBy(field => field.Name, StringComparer.OrdinalIgnoreCase)
                    .Select(field => field.Name + " = " + FormatConstant(field.GetRawConstantValue()));

                WriteMemberSection(writer, "Enum Values", values, memberHeadingLevel);
                return;
            }

            var fields = SafeGetMembers(() => type.GetFields(MemberFlags), warnings, type, "fields")
                .OrderBy(field => field.Name, StringComparer.OrdinalIgnoreCase)
                .Select(FormatFieldSignature);
            WriteMemberSection(writer, "Fields", fields, memberHeadingLevel);

            var properties = SafeGetMembers(() => type.GetProperties(MemberFlags), warnings, type, "properties")
                .OrderBy(property => property.Name, StringComparer.OrdinalIgnoreCase)
                .Select(FormatPropertySignature);
            WriteMemberSection(writer, "Properties", properties, memberHeadingLevel);

            var eventsInfo = SafeGetMembers(() => type.GetEvents(MemberFlags), warnings, type, "events")
                .OrderBy(@event => @event.Name, StringComparer.OrdinalIgnoreCase)
                .Select(FormatEventSignature);
            WriteMemberSection(writer, "Events", eventsInfo, memberHeadingLevel);

            var constructors = SafeGetMembers(() => type.GetConstructors(MemberFlags), warnings, type, "constructors")
                .OrderBy(ctor => ctor.GetParameters().Length)
                .Select(ctor => FormatConstructorSignature(type, ctor));
            WriteMemberSection(writer, "Constructors", constructors, memberHeadingLevel);

            var methods = SafeGetMembers(() => type.GetMethods(MemberFlags), warnings, type, "methods")
                .Where(method => !IsIgnoredMethod(method))
                .OrderBy(method => method.Name, StringComparer.OrdinalIgnoreCase)
                .Select(FormatMethodSignature);
            WriteMemberSection(writer, "Methods", methods, memberHeadingLevel);
        }
        catch (Exception ex)
        {
            if (ex is FileNotFoundException || ex is FileLoadException)
            {
                warnings.AddMissing(ex);
            }
            else
            {
                warnings.AddWarning($"Failed to render type {SafeTypeId(type)}: {ex.GetType().Name} {ex.Message}");
            }
            writer.WriteLine(GetHeadingPrefix(typeHeadingLevel) + " <unavailable>");
            writer.WriteLine();
        }
    }

    private static void WriteMemberSection(StreamWriter writer, string title, IEnumerable<string> items, int headingLevel)
    {
        var list = items.Where(item => !string.IsNullOrWhiteSpace(item)).ToList();
        if (list.Count == 0)
        {
            return;
        }

        writer.WriteLine(GetHeadingPrefix(headingLevel) + " " + title);
        foreach (var item in list)
        {
            writer.WriteLine("- " + item);
        }
        writer.WriteLine();
    }

    private static T[] SafeGetMembers<T>(Func<T[]> getter, WarningBag warnings, Type type, string memberName)
    {
        try
        {
            return getter();
        }
        catch (Exception ex)
        {
            if (ex is FileNotFoundException || ex is FileLoadException)
            {
                warnings.AddMissing(ex);
            }
            else
            {
                warnings.AddWarning($"Failed to read {memberName} for {SafeTypeId(type)}: {ex.GetType().Name} {ex.Message}");
            }
            return Array.Empty<T>();
        }
    }

    private static string FormatFieldSignature(FieldInfo field)
    {
        var access = GetAccessModifier(field);
        var modifiers = new List<string> { access };

        if (field.IsStatic)
        {
            modifiers.Add("static");
        }

        if (field.IsLiteral && !field.IsInitOnly)
        {
            modifiers.Add("const");
        }
        else if (field.IsInitOnly)
        {
            modifiers.Add("readonly");
        }

        var typeName = GetTypeDisplayName(field.FieldType, true);
        return string.Join(" ", modifiers) + " " + typeName + " " + field.Name;
    }

    private static string FormatPropertySignature(PropertyInfo property)
    {
        var getter = property.GetGetMethod(true);
        var setter = property.GetSetMethod(true);
        var access = GetMostAccessible(getter, setter);
        var modifiers = new List<string> { access };

        var accessor = getter ?? setter;
        if (accessor != null && accessor.IsStatic)
        {
            modifiers.Add("static");
        }

        var typeName = GetTypeDisplayName(property.PropertyType, true);
        var accessors = new List<string>();

        if (getter != null)
        {
            var getAccess = GetAccessModifier(getter);
            accessors.Add(getAccess == access ? "get" : getAccess + " get");
        }

        if (setter != null)
        {
            var setAccess = GetAccessModifier(setter);
            accessors.Add(setAccess == access ? "set" : setAccess + " set");
        }

        return string.Join(" ", modifiers) + " " + typeName + " " + property.Name + " { " + string.Join("; ", accessors) + "; }";
    }

    private static string FormatEventSignature(EventInfo eventInfo)
    {
        var addMethod = eventInfo.AddMethod;
        var removeMethod = eventInfo.RemoveMethod;
        var access = GetMostAccessible(addMethod, removeMethod);
        var modifiers = new List<string> { access };

        var accessor = addMethod ?? removeMethod;
        if (accessor != null && accessor.IsStatic)
        {
            modifiers.Add("static");
        }

        var handlerType = eventInfo.EventHandlerType ?? typeof(void);
        var typeName = GetTypeDisplayName(handlerType, true);
        return string.Join(" ", modifiers) + " event " + typeName + " " + eventInfo.Name;
    }

    private static string FormatConstructorSignature(Type type, ConstructorInfo ctor)
    {
        var access = GetAccessModifier(ctor);
        var modifiers = new List<string> { access };

        if (ctor.IsStatic)
        {
            modifiers.Add("static");
        }

        var parameters = string.Join(", ", ctor.GetParameters().Select(FormatParameter));
        var name = GetTypeDisplayName(type, false);
        return string.Join(" ", modifiers) + " " + name + "(" + parameters + ")";
    }

    private static string FormatMethodSignature(MethodInfo method)
    {
        var access = GetAccessModifier(method);
        var modifiers = new List<string> { access };

        if (method.IsStatic)
        {
            modifiers.Add("static");
        }

        if (method.IsAbstract && !method.DeclaringType.IsInterface)
        {
            modifiers.Add("abstract");
        }
        else if (method.IsVirtual && !method.DeclaringType.IsInterface)
        {
            var isOverride = false;
            try
            {
                isOverride = method.GetBaseDefinition() != method;
            }
            catch (NotSupportedException)
            {
                isOverride = false;
            }
            catch (InvalidOperationException)
            {
                isOverride = false;
            }

            if (isOverride)
            {
                modifiers.Add("override");
            }
            else if (!method.IsFinal)
            {
                modifiers.Add("virtual");
            }
        }

        var returnType = GetTypeDisplayName(method.ReturnType, true);
        var name = method.Name;

        if (method.IsGenericMethodDefinition)
        {
            var genericArgs = method.GetGenericArguments().Select(arg => arg.Name);
            name += "<" + string.Join(", ", genericArgs) + ">";
        }

        var parameters = string.Join(", ", method.GetParameters().Select(FormatParameter));
        return string.Join(" ", modifiers) + " " + returnType + " " + name + "(" + parameters + ")";
    }

    private static string FormatParameter(ParameterInfo parameter)
    {
        var parameterType = parameter.ParameterType;
        var modifier = string.Empty;

        if (parameterType.IsByRef)
        {
            if (parameter.IsOut)
            {
                modifier = "out ";
            }
            else if (parameter.IsIn)
            {
                modifier = "in ";
            }
            else
            {
                modifier = "ref ";
            }
            parameterType = parameterType.GetElementType();
        }
        else if (parameter.GetCustomAttributes(typeof(ParamArrayAttribute), false).Length > 0)
        {
            modifier = "params ";
        }

        var typeName = GetTypeDisplayName(parameterType, true);
        var defaultValue = string.Empty;
        if (parameter.HasDefaultValue)
        {
            defaultValue = " = " + FormatConstant(parameter.DefaultValue);
        }

        return modifier + typeName + " " + parameter.Name + defaultValue;
    }

    private static bool IsIgnoredMethod(MethodInfo method)
    {
        if (!method.IsSpecialName)
        {
            return false;
        }

        return !method.Name.StartsWith("op_", StringComparison.Ordinal);
    }

    private static string GetTypeKind(Type type)
    {
        if (type.IsInterface)
        {
            return "interface";
        }

        if (type.IsEnum)
        {
            return "enum";
        }

        if (type.IsValueType)
        {
            return "struct";
        }

        if (type.BaseType == typeof(MulticastDelegate))
        {
            return "delegate";
        }

        return "class";
    }

    private static string GetTypeDisplayName(Type type, bool includeNamespace)
    {
        if (type == null)
        {
            return "void";
        }

        if (TryGetTypeAlias(type, out var alias))
        {
            return alias;
        }

        if (type.IsArray)
        {
            var rank = type.GetArrayRank();
            var suffix = rank == 1 ? "[]" : "[" + new string(',', rank - 1) + "]";
            return GetTypeDisplayName(type.GetElementType(), includeNamespace) + suffix;
        }

        if (type.IsPointer)
        {
            return GetTypeDisplayName(type.GetElementType(), includeNamespace) + "*";
        }

        if (type.IsByRef)
        {
            return GetTypeDisplayName(type.GetElementType(), includeNamespace);
        }

        if (type.IsGenericParameter)
        {
            return type.Name;
        }

        if (type.IsGenericType)
        {
            var definition = type.GetGenericTypeDefinition();
            var baseName = definition.Name;
            var tickIndex = baseName.IndexOf('`');
            if (tickIndex >= 0)
            {
                baseName = baseName.Substring(0, tickIndex);
            }

            var prefix = string.Empty;
            if (definition.IsNested)
            {
                prefix = GetTypeDisplayName(definition.DeclaringType, includeNamespace) + ".";
            }
            else if (includeNamespace && !string.IsNullOrEmpty(definition.Namespace))
            {
                prefix = definition.Namespace + ".";
            }

            var args = type.GetGenericArguments().Select(arg => GetTypeDisplayName(arg, includeNamespace));
            return prefix + baseName + "<" + string.Join(", ", args) + ">";
        }

        if (type.IsNested)
        {
            return GetTypeDisplayName(type.DeclaringType, includeNamespace) + "." + type.Name;
        }

        var nsPrefix = includeNamespace && !string.IsNullOrEmpty(type.Namespace) ? type.Namespace + "." : string.Empty;
        return nsPrefix + type.Name;
    }

    private static bool TryGetTypeAlias(Type type, out string alias)
    {
        if (TypeAliases.TryGetValue(type, out alias))
        {
            return true;
        }

        var fullName = type.FullName;
        if (!string.IsNullOrWhiteSpace(fullName) && TypeAliasNames.TryGetValue(fullName, out alias))
        {
            return true;
        }

        alias = null;
        return false;
    }

    private static string GetAccessModifier(Type type)
    {
        if (type.IsNestedPublic || type.IsPublic)
        {
            return "public";
        }

        if (type.IsNestedFamORAssem)
        {
            return "protected internal";
        }

        if (type.IsNestedFamANDAssem)
        {
            return "private protected";
        }

        if (type.IsNestedFamily)
        {
            return "protected";
        }

        if (type.IsNestedAssembly || type.IsNotPublic)
        {
            return "internal";
        }

        return "private";
    }

    private static string GetAccessModifier(MethodBase method)
    {
        if (method.IsPublic)
        {
            return "public";
        }

        if (method.IsFamilyOrAssembly)
        {
            return "protected internal";
        }

        if (method.IsFamilyAndAssembly)
        {
            return "private protected";
        }

        if (method.IsFamily)
        {
            return "protected";
        }

        if (method.IsAssembly)
        {
            return "internal";
        }

        return "private";
    }

    private static string GetAccessModifier(FieldInfo field)
    {
        if (field.IsPublic)
        {
            return "public";
        }

        if (field.IsFamilyOrAssembly)
        {
            return "protected internal";
        }

        if (field.IsFamilyAndAssembly)
        {
            return "private protected";
        }

        if (field.IsFamily)
        {
            return "protected";
        }

        if (field.IsAssembly)
        {
            return "internal";
        }

        return "private";
    }

    private static string GetMostAccessible(MethodBase first, MethodBase second)
    {
        var best = first;
        var bestRank = GetAccessibilityRank(first);
        var secondRank = GetAccessibilityRank(second);
        if (secondRank > bestRank)
        {
            best = second;
        }

        return best != null ? GetAccessModifier(best) : "private";
    }

    private static int GetAccessibilityRank(MethodBase method)
    {
        if (method == null)
        {
            return -1;
        }

        if (method.IsPublic)
        {
            return 5;
        }

        if (method.IsFamilyOrAssembly)
        {
            return 4;
        }

        if (method.IsFamily)
        {
            return 3;
        }

        if (method.IsAssembly)
        {
            return 2;
        }

        if (method.IsFamilyAndAssembly)
        {
            return 1;
        }

        return 0;
    }

    private static string FormatConstant(object value)
    {
        if (ReferenceEquals(value, Missing.Value))
        {
            return "missing";
        }

        if (ReferenceEquals(value, DBNull.Value))
        {
            return "null";
        }

        if (value == null)
        {
            return "null";
        }

        if (value is string text)
        {
            return "\"" + text.Replace("\"", "\\\"") + "\"";
        }

        if (value is char c)
        {
            return "'" + c + "'";
        }

        if (value is bool flag)
        {
            return flag ? "true" : "false";
        }

        if (value is IFormattable formattable)
        {
            return formattable.ToString(null, CultureInfo.InvariantCulture);
        }

        return value.ToString();
    }

    private static string ToRelativePath(string path)
    {
        try
        {
            var current = Directory.GetCurrentDirectory();
            return Path.GetRelativePath(current, path);
        }
        catch
        {
            return path;
        }
    }

    private static string GetHeadingPrefix(int level)
    {
        if (level < 1)
        {
            level = 1;
        }
        else if (level > 6)
        {
            level = 6;
        }

        return new string('#', level);
    }

    private static string GetAssemblyFileName(string assemblyName)
    {
        if (string.IsNullOrWhiteSpace(assemblyName))
        {
            return "UnknownAssembly.md";
        }

        var builder = new StringBuilder();
        foreach (var ch in assemblyName)
        {
            if (char.IsLetterOrDigit(ch) || ch == '.' || ch == '-' || ch == '_')
            {
                builder.Append(ch);
            }
            else
            {
                builder.Append('_');
            }
        }

        return builder + ".md";
    }

    private static string SafeTypeId(Type type)
    {
        try
        {
            return type.FullName ?? type.Name ?? "<unknown>";
        }
        catch
        {
            return "<unknown>";
        }
    }

    private static string TryGetMissingAssemblyName(Exception ex)
    {
        if (ex is FileNotFoundException fileNotFound)
        {
            var name = fileNotFound.FileName;
            if (!string.IsNullOrWhiteSpace(name))
            {
                try
                {
                    var assemblyName = new AssemblyName(name).Name;
                    if (!string.IsNullOrWhiteSpace(assemblyName))
                    {
                        return assemblyName;
                    }
                }
                catch
                {
                    // Ignore parse errors and fall back to filename parsing.
                }

                var fileName = Path.GetFileNameWithoutExtension(name);
                if (!string.IsNullOrWhiteSpace(fileName))
                {
                    return fileName;
                }
            }
        }

        if (ex is FileLoadException fileLoad)
        {
            var name = fileLoad.FileName;
            if (!string.IsNullOrWhiteSpace(name))
            {
                try
                {
                    var assemblyName = new AssemblyName(name).Name;
                    if (!string.IsNullOrWhiteSpace(assemblyName))
                    {
                        return assemblyName;
                    }
                }
                catch
                {
                    // Ignore parse errors and fall back to filename parsing.
                }

                var fileName = Path.GetFileNameWithoutExtension(name);
                if (!string.IsNullOrWhiteSpace(fileName))
                {
                    return fileName;
                }
            }
        }

        return null;
    }

    private sealed class WarningBag
    {
        private readonly HashSet<string> warnings = new HashSet<string>(StringComparer.Ordinal);
        private readonly HashSet<string> missingAssemblies = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        public void AddWarning(string message)
        {
            if (!string.IsNullOrWhiteSpace(message))
            {
                warnings.Add(message);
            }
        }

        public void AddMissing(Exception ex)
        {
            var missingName = TryGetMissingAssemblyName(ex);
            if (!string.IsNullOrWhiteSpace(missingName))
            {
                missingAssemblies.Add(missingName);
            }
            else
            {
                AddWarning(ex.GetType().Name + " " + ex.Message);
            }
        }

        public List<string> GetAllWarnings()
        {
            var list = new List<string>();
            if (missingAssemblies.Count > 0)
            {
                list.Add("Missing dependencies: " + string.Join(", ", missingAssemblies.OrderBy(item => item, StringComparer.OrdinalIgnoreCase)));
                list.Add("Some types may be incomplete due to missing dependencies.");
            }

            list.AddRange(warnings.OrderBy(item => item, StringComparer.Ordinal));
            return list;
        }
    }

    private sealed class TypeEntry
    {
        public TypeEntry(Type type, string ns, string name)
        {
            Type = type;
            Namespace = ns;
            Name = name;
        }

        public Type Type { get; }
        public string Namespace { get; }
        public string Name { get; }

        public static TypeEntry TryCreate(Type type, WarningBag warnings)
        {
            try
            {
                var ns = type.Namespace ?? "(global)";
                var name = type.Name;
                return new TypeEntry(type, ns, name);
            }
            catch (Exception ex)
            {
                if (ex is FileNotFoundException || ex is FileLoadException)
                {
                    warnings.AddMissing(ex);
                }
                else
                {
                    warnings.AddWarning($"读取类型元数据失败 {SafeTypeId(type)}: {ex.GetType().Name} {ex.Message}");
                }
                return null;
            }
        }
    }

    private sealed class AssemblyEntry
    {
        public AssemblyEntry(string name, string path, List<Type> types)
        {
            Name = name;
            Path = path;
            Types = types;
        }

        public string Name { get; }
        public string Path { get; }
        public List<Type> Types { get; }
    }

    private sealed class Options
    {
        public string LibDir { get; private set; } = "tools/WorldBox.Managed";
        public string OutputPath { get; private set; } = "docs/api/index.md";
        public List<string> IncludeDlls { get; } = new List<string>();
        public List<string> Warnings { get; } = new List<string>();
        public bool IncludeAll { get; private set; }
        public bool SplitByAssembly { get; private set; } = true;
        public bool ShowHelp { get; private set; }
        public bool IsValid { get; private set; } = true;
        public string ErrorMessage { get; private set; }

        public static Options Parse(string[] args)
        {
            var options = new Options();
            for (var i = 0; i < args.Length; i++)
            {
                var arg = args[i];
                switch (arg)
                {
                    case "--lib":
                        if (!TryReadValue(args, ref i, out var libDir))
                        {
                            options.IsValid = false;
                            options.ErrorMessage = "Missing value for --lib";
                        }
                        else
                        {
                            options.LibDir = libDir;
                        }
                        break;
                    case "--out":
                        if (!TryReadValue(args, ref i, out var outPath))
                        {
                            options.IsValid = false;
                            options.ErrorMessage = "Missing value for --out";
                        }
                        else
                        {
                            options.OutputPath = outPath;
                        }
                        break;
                    case "--dll":
                        if (!TryReadValue(args, ref i, out var dllName))
                        {
                            options.IsValid = false;
                            options.ErrorMessage = "Missing value for --dll";
                        }
                        else
                        {
                            options.IncludeDlls.Add(dllName);
                        }
                        break;
                    case "--all":
                        options.IncludeAll = true;
                        break;
                    case "--single":
                        options.SplitByAssembly = false;
                        break;
                    case "--help":
                    case "-h":
                        options.ShowHelp = true;
                        break;
                    default:
                        options.Warnings.Add("Unknown argument: " + arg);
                        break;
                }

                if (!options.IsValid)
                {
                    break;
                }
            }

            if (options.IsValid && !options.ShowHelp && !options.IncludeAll && options.IncludeDlls.Count == 0)
            {
                options.IncludeDlls.AddRange(DefaultDlls);
            }

            return options;
        }

        private static bool TryReadValue(string[] args, ref int index, out string value)
        {
            value = null;
            if (index + 1 >= args.Length)
            {
                return false;
            }

            index++;
            value = args[index];
            return true;
        }
    }
}
