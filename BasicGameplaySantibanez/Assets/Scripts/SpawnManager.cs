using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;

    private float spawnRangeX = 20.0f;
    private float spawnPosZ = 28.0f;
    private float sideSpawnX = 22f;
    private float minSideZ = 14;
    private float maxSideZ = -1;

    private float startDelay = 2.0f;
    private float minSpawnInterval = 1.0f;
    private float maxSpawnInterval = 4.0f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, Random.Range(minSpawnInterval,maxSpawnInterval));
        InvokeRepeating("SpawnLeftAnimal", startDelay, Random.Range(minSpawnInterval, maxSpawnInterval));
        InvokeRepeating("SpawnRightAnimal", startDelay, Random.Range(minSpawnInterval, maxSpawnInterval));
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }

    void SpawnLeftAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 SpawnPos = new Vector3(-sideSpawnX, 0, Random.Range(minSideZ, maxSideZ));

        Vector3 rotation = new Vector3(0, 90, 0);
        Instantiate(animalPrefabs[animalIndex], SpawnPos, Quaternion.Euler(rotation));
    }

    void SpawnRightAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 SpawnPos = new Vector3(sideSpawnX, 0, Random.Range(minSideZ, maxSideZ));

        Vector3 rotation = new Vector3(0, -90, 0);
        Instantiate(animalPrefabs[animalIndex], SpawnPos, Quaternion.Euler(rotation));
    }
}
