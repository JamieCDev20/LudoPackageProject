using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Extensions
{

    public static bool Between(this int x, int min, int max)
    {
        return ((x - min) | (max - x)) >= 0;
    }

    public static bool Between(this float x, float min, float max)
    {
        return (x >= min) && (x <= max);
    }

}
