using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Extensions
{
    #region Number

    public static bool Between(this int x, int min, int max)
    {
        return ((x - min) | (max - x)) >= 0;
    }
    public static bool Between(this float x, float min, float max)
    {
        return (x >= min) && (x <= max);
    }

    #endregion

    #region Vector

    public static Vector3 FlattenX(this Vector3 v)
    {
        v.x = 0;
        return v;
    }
    public static Vector3 FlattenY(this Vector3 v)
    {
        v.y = 0;
        return v;
    }
    public static Vector3 FlattenZ(this Vector3 v)
    {
        v.z = 0;
        return v;
    }

    public static Vector3 Times(this Vector3 a, Vector3 b)
    {
        a.x *= b.x;
        a.y *= b.y;
        a.z *= b.z;
        return a;
    }

    public static Vector3 ToVector3(this Vector2 a)
    {
        return new Vector3(a.x, 0, a.y);
    }

    #endregion

}
