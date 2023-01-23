using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerUpdate : Follower
{
    private void Update()
    {
        Move(Time.deltaTime);
    }
}
