namespace EraOfWheel.Cycle
{
    /// <summary>
    /// 纪元阶段枚举
    /// </summary>
    public enum CyclePhase
    {
        /// <summary>萌芽期 - 文明初生</summary>
        Germination = 0,
        
        /// <summary>成长期 - 文明发展</summary>
        Growth = 1,
        
        /// <summary>鼎盛期 - 文明巅峰</summary>
        Prosperity = 2,
        
        /// <summary>衰落期 - 文明衰退</summary>
        Decline = 3,
        
        /// <summary>灭绝期 - 文明消亡</summary>
        Extinction = 4
    }

    /// <summary>
    /// 阶段配置
    /// </summary>
    public static class CyclePhaseConfig
    {
        public static string GetPhaseName(CyclePhase phase) => phase switch
        {
            CyclePhase.Germination => "萌芽",
            CyclePhase.Growth => "成长",
            CyclePhase.Prosperity => "鼎盛",
            CyclePhase.Decline => "衰落",
            CyclePhase.Extinction => "灭绝",
            _ => "未知"
        };

        public static float GetPhaseDuration(CyclePhase phase) => phase switch
        {
            CyclePhase.Germination => 100f,
            CyclePhase.Growth => 200f,
            CyclePhase.Prosperity => 150f,
            CyclePhase.Decline => 100f,
            CyclePhase.Extinction => 50f,
            _ => 100f
        };
    }
}
