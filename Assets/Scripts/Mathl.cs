using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The L stands for Ludophoria :-P
/// </summary>
public static class Mathl
{
    
    public static float Sin(float x)
    {
        return Mathf.Sin(x);
    }
    public static float Sin(float x, float amplitude, float frequency, float xOffset, float yOffset)
    {
        return amplitude * Sin(frequency * x + xOffset) + yOffset;
    }
    public static float NormalisedSin(float x)
    {
        return Sin(x * Mathf.PI);
    }
    public static float NormalisedSin(float x, float amplitude, float frequency, float xOffset, float yOffset)
    {
        return amplitude * Sin(frequency * x + xOffset) + yOffset;
    }
    public static float SkewedSin(float x, float skew, int dir)
    {
        return NormalisedSin(Mathf.PI * x + (Sin(x)*(skew/dir))) * dir;
    }
    public static float WobbleSin(float x)
    {
        return 0.33f * Sin(2.621f * Mathf.PI * x + -Mathf.PI) + (1.314f * x);
    }

}
