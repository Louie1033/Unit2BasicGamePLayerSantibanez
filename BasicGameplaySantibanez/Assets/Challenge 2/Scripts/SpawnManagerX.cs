using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    

    // Start is called before the first frame update
    void Start()
    {
        SpawnRandomBall();
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        int balllIndex = Random.Range(0, ballPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
        float spawnInterval = Random.Range(3.0f, 5.0f);
        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[balllIndex], spawnPos, ballPrefabs[balllIndex].transform.rotation);
        Invoke("SpawnRandomBall", Random.Range(2f,5f));
    }

}
