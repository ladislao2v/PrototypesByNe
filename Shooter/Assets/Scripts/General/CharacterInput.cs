using System;
using System.Collections;
using UnityEngine;

public class CharacterInput : MonoBehaviour
{
    private IControllable _controllable;
    private IShoottable _shoottable;

    private void Awake()
    {
        _controllable = GetComponent<IControllable>();
        _shoottable = GetComponent<IShoottable>();

        if (_controllable == null)
            throw new Exception("There is no IControllable");
        if (_shoottable == null)
            throw new Exception("There is no IShoottable");
    }

    private void Update()
    {
        ReadMove();
        ReadShooting();
    }

    private void ReadMove()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
        var direction = new Vector3(horizontal, 0f, vertical);

        _controllable.Move(direction);
    }

    private void ReadShooting()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
            _shoottable.Shoot();
    }
}
