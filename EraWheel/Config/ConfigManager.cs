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

        public string DefaultConfigPath => GetDefaultConfigPath();
        public string UserConfigPath => GetUserConfigPath();

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
            UserConfig = LoadMergedFromFile(userPath, DefaultConfig);
            if (UserConfig == null)
            {
                UserConfig = CloneConfig(DefaultConfig);
                SaveToFile(userPath, UserConfig);
            }
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

        public bool ExportUserConfig(string path)
        {
            if (string.IsNullOrEmpty(path)) return false;
            var cfg = UserConfig ?? DefaultConfig;
            if (cfg == null) return false;
            SaveToFile(path, cfg);
            return true;
        }

        public bool ImportUserConfig(string path)
        {
            if (string.IsNullOrEmpty(path)) return false;
            var cfg = LoadMergedFromFile(path, DefaultConfig);
            if (cfg == null) return false;
            ConfigSchema.ValidateAndClamp(cfg);
            UserConfig = cfg;
            SaveUserConfig();
            return true;
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

        private ModConfig LoadMergedFromFile(string path, ModConfig fallback)
        {
            try
            {
                if (!File.Exists(path)) return null;
                var json = File.ReadAllText(path);
                if (string.IsNullOrEmpty(json)) return null;

                var baseConfig = CloneConfig(fallback ?? new ModConfig());
                if (JsonCompat.TryOverwriteJson(json, baseConfig))
                {
                    return baseConfig;
                }

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

        private static ModConfig CloneConfig(ModConfig cfg)
        {
            if (cfg == null) return new ModConfig();
            var json = JsonCompat.ToJson(cfg, false);
            var clone = JsonCompat.FromJson<ModConfig>(json);
            return clone ?? new ModConfig();
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
                var asm = System.Reflection.Assembly.GetExecutingAssembly();
                if (NeoModLoader.api.ModDeclareExtensions.TryGetDeclaration(asm, out var decl))
                {
                    var folder = decl != null ? decl.FolderPath : null;
                    if (!string.IsNullOrEmpty(folder)) return folder;
                }
            }
            catch
            {
            }

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
