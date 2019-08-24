using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MathHelper
{
    public static bool IsBetween(this int target, int left, int right) { return left <= target && target < right; }
    public static bool IsBetween(this float target, float left, float right) { return left <= target && target < right; }
}
