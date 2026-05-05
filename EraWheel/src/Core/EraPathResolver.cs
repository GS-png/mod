using System;
using System.IO;

namespace EraWheel.Core;

public static class EraPathResolver
{
    public static string ResolveModPath(string modRootPath, string relativePath)
    {
        string primaryPath = Path.GetFullPath(Path.Combine(modRootPath, relativePath));
        if (File.Exists(primaryPath) || Directory.Exists(primaryPath))
        {
            return primaryPath;
        }

        return primaryPath;
    }

    public static string ToModRelativePath(string modRootPath, string absolutePath)
    {
        return NormalizePath(Path.GetRelativePath(modRootPath, absolutePath));
    }

    private static string NormalizePath(string path)
    {
        return path.Replace('\\', '/');
    }
}
