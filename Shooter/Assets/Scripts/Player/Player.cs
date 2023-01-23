using UnityEngine;

public class Player : Character, IControllable
{
    [Header("Move Speed")]
    [SerializeField] private float _playerSpeed = 10f;

    private Vector3 _moveDirection;

    private CharacterController _character;
    private Rifle _rifle;

    private string _isRun = "Run";

    private void Awake()
    {
        _character = GetComponent<CharacterController>();
        _rifle = GetComponent<Rifle>();
    }

    private void FixedUpdate()
    {
        MoveIternal();
    }

    public void Move(Vector3 direction)
    {
        _moveDirection = direction;
    }

    private void MoveIternal()
    {
        if (_moveDirection.x != 0 || _moveDirection.z != 0)
            _animator.SetBool(_isRun, true);
        else
            _animator.SetBool(_isRun, false);

        if (Vector3.Angle(Vector3.forward, _moveDirection) > 1f || Vector3.Angle(Vector3.forward, _moveDirection) == 0f)
        {
            Vector3 direction = Vector3.RotateTowards(transform.forward, _moveDirection, _playerSpeed, 0f);
            transform.rotation = Quaternion.LookRotation(direction);
        }

        _character.Move(_moveDirection * _playerSpeed * Time.fixedDeltaTime);
    }

    public override void Shoot()
    {
        base.Shoot();
        _rifle.MakeShoot();
    }
}
