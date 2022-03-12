using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    public GameObject[] obstaclePrefab;
    public GameObject SpawnPoint;
    float StartDelay = 2f;
    float spawnInterval = 1.5f;
    void Start()
    {
        InvokeRepeating("spawnObstacles", StartDelay, spawnInterval);
    }

    // Update is called once per frame

    void spawnObstacles()
    {
        int obstacleIndex = Random.Range(0, obstaclePrefab.Length);
        Instantiate(obstaclePrefab[obstacleIndex], SpawnPoint.transform.position, obstaclePrefab[obstacleIndex].transform.rotation);
    }
}
