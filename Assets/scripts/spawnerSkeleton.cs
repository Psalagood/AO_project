using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class spawnerSkeleton : MonoBehaviour
{
    public Transform SpawnPos;
    public GameObject enemy;

    void Start()
    {
        StartCoroutine(SpawnCD());
    }

    void Update()
    {
        StartCoroutine(SpawnCD());
    }

    IEnumerator SpawnCD()
    {
        yield return new WaitForSeconds(3f);
        Instantiate(enemy, SpawnPos.position, Quaternion.identity);
    }
}
