using System;
using System.IO;
using EraWheel.Core;

namespace EraWheel.Config
{
    public class ConfigManager
    {
        public ModConfig DefaultConfig { get; private set; }
        public ModConfig UserConfig { get; private set; }
        public ModConfig RuntimeConfig { get; private set; }

        public ModConfig Config
        {
            get
            {
                if (RuntimeConfig != null) return RuntimeConfig;
                if (UserConfig != null) return UserConfig;
                return DefaultConfig;
            }
        }

        public string ModRootPath { get; private set; }

        public ConfigManager()
        {
            ModRootPath = ResolveModRootPath();
        }

        public void Load()
        {
            DefaultConfig = LoadFromFile(GetDefaultConfigPath()) ?? new ModConfig();
            ConfigSchema.ValidateAndClamp(DefaultConfig);

            var userPath = GetUserConfigPath();
            if (!File.Exists(userPath))
            {
                SaveToFile(userPath, DefaultConfig);
            }

            UserConfig = LoadFromFile(userPath) ?? DefaultConfig;
            ConfigSchema.ValidateAndClamp(UserConfig);
        }

        public void SetRuntimeConfig(ModConfig cfg)
        {
            RuntimeConfig = cfg;
            if (RuntimeConfig != null)
            {
                ConfigSchema.ValidateAndClamp(RuntimeConfig);
            }
        }

        public void ClearRuntimeConfig()
        {
            RuntimeConfig = null;
        }

        public void SaveUserConfig()
        {
            if (UserConfig == null) return;
            SaveToFile(GetUserConfigPath(), UserConfig);
        }

        public void ResetToDefault()
        {
            UserConfig = JsonCompat.FromJson<ModConfig>(JsonCompat.ToJson(DefaultConfig, false)) ?? new ModConfig();
            ConfigSchema.ValidateAndClamp(UserConfig);
            SaveUserConfig();
        }

        private ModConfig LoadFromFile(string path)
        {
            try
            {
                if (!File.Exists(path)) return null;
                var json = File.ReadAllText(path);
                if (string.IsNullOrEmpty(json)) return null;
                return JsonCompat.FromJson<ModConfig>(json);
            }
            catch
            {
                return null;
            }
        }

        private void SaveToFile(string path, ModConfig cfg)
        {
            try
            {
                var dir = Path.GetDirectoryName(path);
                if (!string.IsNullOrEmpty(dir))
                {
                    Directory.CreateDirectory(dir);
                }

                var json = JsonCompat.ToJson(cfg, true);
                File.WriteAllText(path, json);
            }
            catch
            {
            }
        }

        private string GetDefaultConfigPath()
        {
            return Path.Combine(ModRootPath, "Config", "DefaultConfig.json");
        }

        private string GetUserConfigPath()
        {
            return Path.Combine(ModRootPath, "Config", "config.json");
        }

        private static string ResolveModRootPath()
        {
            try
            {
                var loc = System.Reflection.Assembly.GetExecutingAssembly().Location;
                if (!string.IsNullOrEmpty(loc))
                {
                    var dir = Path.GetDirectoryName(loc);
                    if (!string.IsNullOrEmpty(dir)) return dir;
                }
            }
            catch
            {
            }

            return Directory.GetCurrentDirectory();
        }
    }
}
