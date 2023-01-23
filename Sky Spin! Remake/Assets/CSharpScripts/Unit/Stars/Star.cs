using NTC.Global.System;
using UnityEngine;

public class Star : Unit
{
    [SerializeField] private StarsWallet _star;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Player>(out Player player))
        {
            _star.ReceiveStars(1);
            gameObject.Disable();
        }
    }
}
