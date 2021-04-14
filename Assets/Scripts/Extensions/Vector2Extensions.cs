using UnityEngine;

/// <summary>
/// Defines extensions methods for <see cref="Vector2"/>
/// </summary>
public static class Vector2Extensions
{
    /// <summary>
    /// Rotates a <see cref="Vector2"/> by a given angle
    /// </summary>
    /// <param name="v"></param>
    /// <param name="degrees">Angle to rotate in degrees</param>
    /// <returns></returns>
    public static Vector2 Rotate (this Vector2 v, float degrees)
    {
        return Quaternion.Euler(0, 0, degrees) * v;
    }
}