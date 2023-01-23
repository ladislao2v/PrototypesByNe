using UnityEngine;

public class Bullet : MonoBehaviour
{
    private int _damage = 10;
    private float _bulletSpeed = 100f;

    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public int GetDamage()
    {
        return _damage;
    }

    public void UpdateDamage(int damage)
    {
        _damage += damage;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out IDamagable character))
        {
            Debug.Log(_damage);
            character.ApplyDamage(_damage);
        }
    }

    private void FixedUpdate()
    {
        _rigidbody.AddForce(Vector3.forward * _bulletSpeed * Time.fixedDeltaTime, ForceMode.Impulse);
    }
}
