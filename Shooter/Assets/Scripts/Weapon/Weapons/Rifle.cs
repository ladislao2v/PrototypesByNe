using UnityEngine;

public class Rifle : Weapon
{
    private int _shops = 5;

    [SerializeField] private Bullet _bullet;

    private WeaponShop _shop;

    private Transform _transform;

    private void Awake()
    {
        _transform = GetComponent<Transform>();
        _shop = GetComponent<WeaponShop>();
    }

    public override void MakeShoot()
    {
        if (_shop.CurrentBulletsCount == 0 && _shops > 0)
            Reload();

        Vector3 offset = new Vector3(0, 1f, 1f);

        Instantiate(_bullet, _transform.position + offset, Quaternion.identity);
        _shop.ReduceBullet();
    }

    public override WeaponShop TakeShop()
    {
        return new WeaponShop();
    }

    public override void Reload()
    {
        
    }
}
