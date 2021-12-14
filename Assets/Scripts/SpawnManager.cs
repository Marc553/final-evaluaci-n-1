using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstaclePrefabs;
    private Vector3 SpawnPosition;
    private float xRange = 200f;
    private float zRange = 200f;
    private float yRange = 200f;
    private float startTmie = 2;
    private float repeatRate = 1.5f;
    private float randomZ;
    private float randomX;
    private float randomY;
    private int randomIdex;
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startTmie, repeatRate);
    }

    public Vector3 RandomSpawnPosition()
    {
        randomZ = Random.Range(-zRange, zRange);
        randomX = Random.Range(-xRange, xRange);
        randomY = Random.Range(0, yRange);
        return new Vector3(randomX, 0, randomZ);
    }

    public void SpawnObstacle()
    {
        randomIdex = Random.Range(0, obstaclePrefabs.Length); //numero entre 0 y maximo numero d objetos d mi "animalPrefabs
        SpawnPosition = RandomSpawnPosition();
        Instantiate(obstaclePrefabs[randomIdex], SpawnPosition, obstaclePrefabs[randomIdex].transform.rotation);
    }

}
