using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using EraWheel.Core.Logging;
using HarmonyLib;

namespace EraWheel.Systems.Stats;

[HarmonyPatch(typeof(Actor), "updateStats")]
public static class EraActorModifierInjectionPatch
{
    private static readonly MethodInfo? InjectMethod = AccessTools.Method(
        typeof(EraActorModifierInjectionBridge),
        nameof(EraActorModifierInjectionBridge.InjectPersistentModifiers)
    );

    [HarmonyTranspiler]
    private static IEnumerable<CodeInstruction> Transpile(IEnumerable<CodeInstruction> instructions)
    {
        List<CodeInstruction> codeList = new List<CodeInstruction>(instructions);
        if (InjectMethod == null)
        {
            EraLog.Error(EraLogCategory.Events, "统一属性注入失败：找不到 EraActorModifierInjectionBridge.InjectPersistentModifiers。");
            return codeList;
        }

        int insertIndex = -1;
        for (int index = 0; index <= codeList.Count - 3; index++)
        {
            if (codeList[index].opcode == OpCodes.Ldarg_0 &&
                codeList[index + 1].opcode == OpCodes.Ldarg_0 &&
                Equals(codeList[index + 2].operand, "possessed"))
            {
                insertIndex = index;
                break;
            }
        }

        if (insertIndex < 0)
        {
            EraLog.Error(EraLogCategory.Events, "统一属性注入失败：没有在 Actor.updateStats 里找到 possessed 锚点。");
            return codeList;
        }

        CodeInstruction anchor = codeList[insertIndex];
        List<Label> movedLabels = new List<Label>(anchor.labels);
        List<ExceptionBlock> movedBlocks = new List<ExceptionBlock>(anchor.blocks);
        anchor.labels.Clear();
        anchor.blocks.Clear();

        CodeInstruction loadActor = new CodeInstruction(OpCodes.Ldarg_0);
        loadActor.labels.AddRange(movedLabels);
        loadActor.blocks.AddRange(movedBlocks);

        codeList.Insert(insertIndex, loadActor);
        codeList.Insert(insertIndex + 1, new CodeInstruction(OpCodes.Call, InjectMethod));
        return codeList;
    }
}

public static class EraActorModifierInjectionPatchInstaller
{
    private static bool _patched;

    public static void EnsurePatched()
    {
        if (_patched)
        {
            return;
        }

        Harmony harmony = new Harmony("EraWheel.ActorModifierInjection");
        harmony.CreateClassProcessor(typeof(EraActorModifierInjectionPatch)).Patch();
        _patched = true;
        EraLog.Info(EraLogCategory.Events, "统一属性注入 Harmony 补丁已安装。");
    }
}
