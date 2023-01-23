using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerFixedUpdate : Follower
{
    private void FixedUpdate()
    {
        Move(Time.fixedDeltaTime);
    }
}
