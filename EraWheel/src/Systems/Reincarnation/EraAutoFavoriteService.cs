using System;
using System.Reflection;
using EraWheel.Core.Logging;

namespace EraWheel.Systems.Reincarnation;

public sealed class EraAutoFavoriteService
{
    private const BindingFlags AnyInstance = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;

    private static readonly MethodInfo? IsFavoriteMethod = typeof(Actor).GetMethod("isFavorite", AnyInstance);
    private static readonly MethodInfo? SetFavoriteMethod = typeof(Actor).GetMethod("setFavorite", AnyInstance);
    private static readonly PropertyInfo? FavoriteProperty = typeof(Actor).GetProperty("favorite", AnyInstance);

    public EraAutoFavoriteResult TryFavorite(Actor? actor)
    {
        if (actor == null)
        {
            return EraAutoFavoriteResult.Failed("actor-missing");
        }

        if (actor.asset?.can_be_favorited != true)
        {
            return EraAutoFavoriteResult.Failed("favorite-disabled");
        }

        if (IsAlreadyFavorite(actor))
        {
            return EraAutoFavoriteResult.AlreadyFavorited();
        }

        try
        {
            if (SetFavoriteMethod != null)
            {
                SetFavoriteMethod.Invoke(actor, new object[] { true });
                return EraAutoFavoriteResult.Favorited();
            }

            if (FavoriteProperty != null && FavoriteProperty.CanWrite)
            {
                FavoriteProperty.SetValue(actor, true);
                return EraAutoFavoriteResult.Favorited();
            }

            return EraAutoFavoriteResult.Failed("favorite-api-missing");
        }
        catch (TargetInvocationException exception) when (exception.InnerException != null)
        {
            EraLog.Warning(EraLogCategory.Data, $"EW-057 自动收藏失败：{exception.InnerException.Message}");
            return EraAutoFavoriteResult.Failed("exception");
        }
        catch (Exception exception)
        {
            EraLog.Warning(EraLogCategory.Data, $"EW-057 自动收藏失败：{exception.Message}");
            return EraAutoFavoriteResult.Failed("exception");
        }
    }

    private static bool IsAlreadyFavorite(Actor actor)
    {
        if (IsFavoriteMethod == null)
        {
            return false;
        }

        try
        {
            return IsFavoriteMethod.Invoke(actor, Array.Empty<object>()) as bool? == true;
        }
        catch
        {
            return false;
        }
    }
}

public readonly struct EraAutoFavoriteResult
{
    public EraAutoFavoriteResult(bool success, string reason)
    {
        IsSuccess = success;
        Reason = reason;
    }

    public bool IsSuccess { get; }
    public string Reason { get; }

    public bool AlreadyFavorite => string.Equals(Reason, "already-favorited", StringComparison.Ordinal);
    public bool IsFailure => !IsSuccess;

    public static EraAutoFavoriteResult Favorited()
        => new(true, "favorited");

    public static EraAutoFavoriteResult AlreadyFavorited()
        => new(true, "already-favorited");

    public static EraAutoFavoriteResult Failed(string reason)
        => new(false, reason ?? "unknown");
}
