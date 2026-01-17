using System;

namespace EraOfWheel.Core.Config
{
    /// <summary>
    /// MOD配置根类
    /// </summary>
    [Serializable]
    public class ModConfig
    {
        public string version = "1.0.0";
        public bool debug_mode = false;
        public LLMConfig llm = new LLMConfig();
        public GameplayConfig gameplay = new GameplayConfig();
        public UIConfig ui = new UIConfig();
    }

    /// <summary>
    /// LLM API配置
    /// </summary>
    [Serializable]
    public class LLMConfig
    {
        public string api_key = "";
        public string model = "gpt-4";
        public int timeout_seconds = 30;
        public int max_retries = 3;
        public string api_base_url = "https://api.openai.com/v1";
    }

    /// <summary>
    /// 游戏玩法配置
    /// </summary>
    [Serializable]
    public class GameplayConfig
    {
        public float cycle_speed_multiplier = 1.0f;
        public bool enable_legacy_system = true;
        public int max_demon_lords = 10;
        public float awakening_threshold = 100f;
    }

    /// <summary>
    /// UI配置
    /// </summary>
    [Serializable]
    public class UIConfig
    {
        public bool show_tutorial = true;
        public int notification_duration = 5;
        public bool compact_mode = false;
    }
}
