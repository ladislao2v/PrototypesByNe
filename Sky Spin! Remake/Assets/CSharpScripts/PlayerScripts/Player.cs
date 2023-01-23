using NTC.Global.Cache;
using NTC.Global.System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoCache
{
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
