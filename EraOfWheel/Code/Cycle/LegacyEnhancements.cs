using System.Collections.Generic;

namespace EraOfWheel.Cycle
{
    /// <summary>
    /// 遗产强化定义
    /// </summary>
    public static class LegacyEnhancements
    {
        public static readonly List<Enhancement> All = new List<Enhancement>
        {
            // 基础强化
            new Enhancement("cycle_speed_1", "时间加速 I", "轮回速度+10%", 50),
            new Enhancement("cycle_speed_2", "时间加速 II", "轮回速度+25%", 150),
            new Enhancement("starting_bonus", "先祖祝福", "初始资源+20%", 100),
            
            // 对抗魔王
            new Enhancement("resistance_1", "意志坚定 I", "魔王苏醒速度-10%", 75),
            new Enhancement("resistance_2", "意志坚定 II", "魔王苏醒速度-25%", 200),
            new Enhancement("seal_power_1", "封印之力 I", "封印效果+15%", 100),
            
            // 遗产增益
            new Enhancement("legacy_gain_1", "遗产收割 I", "遗产点获取+20%", 125),
            new Enhancement("legacy_gain_2", "遗产收割 II", "遗产点获取+50%", 300),
            
            // 特殊能力
            new Enhancement("prophecy", "预言之眼", "可预见魔王入侵", 250),
            new Enhancement("rewind", "时间回溯", "可撤销一次灾难事件", 500),
        };

        public static Enhancement Get(string id)
        {
            return All.Find(e => e.Id == id);
        }
    }

    public class Enhancement
    {
        public string Id { get; }
        public string Name { get; }
        public string Description { get; }
        public int Cost { get; }

        public Enhancement(string id, string name, string desc, int cost)
        {
            Id = id;
            Name = name;
            Description = desc;
            Cost = cost;
        }
    }
}
