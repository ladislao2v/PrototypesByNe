using UnityEngine;

public abstract class Character : MonoBehaviour, IDamagable, IDieable, IShoottable
{
    private int _currentHealth = 100;
    //private int _maxHealth;

    [SerializeField] protected Animator _animator;

    private const string _isDie = "Die";
    private const string _isHitted = "GetHit";
    private const string _isShoot = "Shoot";

    public void ApplyDamage(int damage)
    {
        if (damage < 0)
            throw new System.Exception("Damage < 0");

        _currentHealth -= damage;
        Debug.Log(_currentHealth);
        _animator.SetTrigger(_isHitted);

        Die(IsDied());
    }

    public bool IsDied()
    {
        if (_currentHealth < 0)
            return true;
        else
            return false;
    }

    public void Die(bool isDied)
    {
        if (isDied)
        {
            _animator.SetTrigger(_isDie);
        }
    }

    public virtual void Shoot()
    {
        _animator.SetTrigger(_isShoot);
    }
}
