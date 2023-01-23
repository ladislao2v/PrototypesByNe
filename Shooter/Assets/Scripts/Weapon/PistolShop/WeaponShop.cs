using UnityEngine;

public class WeaponShop : MonoBehaviour
{
    private int _bulletsCount = 30;
    public int CurrentBulletsCount { get; private set; }

    private void Awake()
    {
        CurrentBulletsCount = _bulletsCount;
    }

    public void ReduceBullet()
    {
        CurrentBulletsCount--;
    }
}
