using UnityEngine;


[RequireComponent(typeof(WeaponShop))]
public abstract class Weapon : MonoBehaviour
{
    public abstract void MakeShoot();
    public abstract void Reload();
    public abstract WeaponShop TakeShop();
}
