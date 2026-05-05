using System;
using EraWheel.Save.Models;
using NeoModLoader.General.Game.extensions;
using Newtonsoft.Json.Linq;

namespace EraWheel.Save.Migration;

public static class EraRuntimeSaveVersioning
{
    public const string ModId = "EraWheel";
    public const string CurrentVersion = "3";
}

public sealed class EraRuntimeSaveEnvelope : ICustomData
{
    public EraWorldRuntimeState Data { get; private set; } = new EraWorldRuntimeState();

    public EraRuntimeSaveEnvelope(EraWorldRuntimeState data)
    {
        if (data != null)
        {
            Data = data;
        }
    }

    public EraRuntimeSaveEnvelope()
        : this(new EraWorldRuntimeState())
    {
    }

    public SerializedCustomData Serialize()
    {
        return new SerializedCustomData(
            EraRuntimeSaveVersioning.ModId,
            EraRuntimeSaveVersioning.CurrentVersion,
            JObject.FromObject(Data)
        );
    }

    public void Deserialize(SerializedCustomData data)
    {
        if (data.ModId != EraRuntimeSaveVersioning.ModId)
        {
            throw new Exception($"读取 EraWheel 运行态存档失败：mod_id 不匹配，收到 {data.ModId}。");
        }

        if (!string.Equals(data.DataVersion, EraRuntimeSaveVersioning.CurrentVersion, StringComparison.Ordinal))
        {
            throw new InvalidOperationException(
                $"暂不支持读取运行态存档版本 {data.DataVersion ?? "<null>"}，请新开世界进行测试。"
            );
        }

        Data = data.Data.ToObject<EraWorldRuntimeState>() ?? new EraWorldRuntimeState();
    }
}
