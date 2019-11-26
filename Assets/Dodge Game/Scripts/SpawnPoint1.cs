using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint1 : MonoBehaviour
{

    public GameObject obstacle;
    public Transform[] spawnPoints;

    private float timeBetweenSpawn =1f;
    public float timeToSpawn = 2f;

    void Update()
    {
        if (Time.time >= timeToSpawn)
        {
            SpawnBlocks();
            timeToSpawn = Time.time + timeBetweenSpawn;
        }
    }

    void SpawnBlocks()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if (randomIndex != i) { 

            Instantiate(obstacle, spawnPoints[i].position, Quaternion.identity);
        }
    }
    }

}
