using NTC.Global.Cache;
using UnityEngine;

public abstract class Unit : MonoCache
{
    [SerializeField] private float _unitSpeed;

    protected override void Run()
    {
        transform.Translate(Vector2.down * _unitSpeed * Time.deltaTime);
    }
}
