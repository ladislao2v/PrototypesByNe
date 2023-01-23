using NTC.Global.Cache;
using NTC.Global.Pool;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitSpawn : MonoCache
{
    [Header("Spawn Positions and Enemy Types")]
    [SerializeField] private List<Unit> _units;
    [SerializeField] private List<GameObject> _spawnPoints;

    [Header("Delay and LivingTime")]
    [SerializeField] private float _livingTime = 5f;
    [SerializeField] private float _delay = 25f;
    private bool _isSpawning = true;

    private IEnumerator SpawnUnit()
    {
        _isSpawning = false;
        int randomUnit = Random.Range(0, _units.Count);
        int randomPoint = Random.Range(0, _spawnPoints.Count);

        NightPool.Despawn(NightPool.Spawn(_units[randomUnit], _spawnPoints[randomPoint].transform.position, Quaternion.identity), _livingTime);

        yield return new WaitForSeconds(_delay);
        _isSpawning = true;
    }

    protected override void Run()
    {
        if(_isSpawning)
            StartCoroutine(SpawnUnit());
    }
}
