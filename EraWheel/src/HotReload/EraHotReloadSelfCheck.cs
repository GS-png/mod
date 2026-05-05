namespace EraWheel.HotReload;

public static class EraHotReloadSelfCheck
{
    public static bool Run(out string message)
    {
        if ((int)EraReloadStage.Preflight != 0 ||
            (int)EraReloadStage.Compile <= (int)EraReloadStage.Preflight ||
            (int)EraReloadStage.Commit <= (int)EraReloadStage.UiRebind)
        {
            message = "阶段枚举顺序异常，事务执行顺序不可信。";
            return false;
        }

        EraReloadResult result = new EraReloadResult();
        if (result.Stats == null ||
            result.Issues == null ||
            result.StageReports == null ||
            result.Outcome != EraReloadOutcome.Pending)
        {
            message = "重载结果模型初始化失败。";
            return false;
        }

        if (result.ErrorCode != EraReloadErrorCode.None)
        {
            message = "重载结果模型初始化失败：默认错误码异常。";
            return false;
        }

        message = "重载事务自检通过。";
        return true;
    }
}
