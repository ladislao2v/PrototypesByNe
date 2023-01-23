using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Follower : MonoBehaviour
{
    [SerializeField] private Transform _target;
    private Transform _follower;

    [SerializeField] private Vector3 _offset;
    [SerializeField] private float _cameraSpeed = 3f;

    private void Awake()
    {
        _follower = GetComponent<Transform>();
    }

    protected void Move(float deltaTime)
    {
        var nextPosition = Vector3.Lerp(_follower.position, _target.position + _offset, deltaTime * _cameraSpeed);
    }
}
