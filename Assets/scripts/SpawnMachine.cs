using System;
using System.Collections.Generic;
using UnityEngine;

public class MobSpawner : MonoBehaviour
{
    public GameObject mobPrefab;
    public float spawnZoneRadius = 10f;
    public int maxMobsInZone = 10;
    public float spawnInterval = 5f;

    private List<GameObject> mobs = new List<GameObject>();
    private System.Random random = new System.Random();
    private bool spawningEnabled = true;

    private void Start()
    {
        InvokeRepeating("SpawnMob", spawnInterval, spawnInterval);
    }

    private void Update()
    {
        if (mobs.Count >= maxMobsInZone)
        {
            Debug.Log("SpawnMob");
            spawningEnabled = false;
        }
        else
        {
            spawningEnabled = true;
        }
    }

    private void SpawnMob()
    {
        if (!spawningEnabled)
        {
            return;
        }

        if (mobs.Count >= maxMobsInZone)
        {
            return;
        }

        Vector3 spawnPosition = GenerateSpawnPosition();
        GameObject newMob = Instantiate(mobPrefab, spawnPosition, Quaternion.identity);
        mobs.Add(newMob);
    }

    private Vector3 GenerateSpawnPosition()
    {
        Vector2 randomCircle = UnityEngine.Random.insideUnitCircle * spawnZoneRadius;
        Vector3 spawnPosition = new Vector3(randomCircle.x, 0f, randomCircle.y) + transform.position;
        return spawnPosition;
    }
}