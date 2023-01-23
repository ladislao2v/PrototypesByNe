using NTC.Global.Cache;
using NTC.Global.System;
using UnityEngine;

public class Enemy : Unit
{
    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.TryGetComponent<Player>(out Player player))
        {
            player.Disable();
            player.RestartGame();
        }
    }
}
