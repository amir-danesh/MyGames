using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 16.0f;
    private float spawnRangeZLowerBound = 3.0f;
    private float spawnRangeZUpperBound = 13.0f;
    private float spawnPosZ = 20.0f;
    private float startDelay = 2.0f;
    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal",startDelay,spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        int randomSpawnPos = Random.Range(0, 4);
        int faceToGo = 0;
        // Quaternion temproryRotation = animalPrefabs[animalIndex].transform.rotation;
        Vector3 spawnPos = new Vector3();
        if (randomSpawnPos <= 1)
        {
            spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            faceToGo = 180;
            Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(0, faceToGo, 0));
        }
        else if(randomSpawnPos == 2)
        {
            spawnPos = new Vector3(-22, 0, Random.Range(spawnRangeZLowerBound, spawnRangeZUpperBound));
            faceToGo = 90;
            Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(0,faceToGo,0));
        }
        else
        {
            spawnPos = new Vector3(22, 0, Random.Range(spawnRangeZLowerBound, spawnRangeZUpperBound));
            faceToGo = -90;
            Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(0,faceToGo,0));
        }
    }
}
