using NTC.Global.Cache;
using UnityEngine;

public class FPSLimiter : MonoCache
{
    private void Awake()
    {
        Application.targetFrameRate = 60;
    }
}
