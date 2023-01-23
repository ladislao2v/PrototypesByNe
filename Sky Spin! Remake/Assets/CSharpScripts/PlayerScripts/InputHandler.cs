using NTC.Global.Cache;
using UnityEngine;

[RequireComponent(typeof(InputHandler))]
public class InputHandler : MonoCache
{
    private bool _isMovingForward = true;

    [Header("Angel of Rotation")]
    [SerializeField] private int _angel;

    protected override void FixedRun()
    {
        RotatePlayer();
    }

    public void OnScreenTouch() => _isMovingForward = _isMovingForward ? false : true;

    private void RotatePlayer ()
    {
        Quaternion rotation = Quaternion.AngleAxis(_angel, GetDirection());
        transform.rotation *= rotation;
    }

    private Vector3 GetDirection() => _isMovingForward ? Vector3.forward : Vector3.back;
}
