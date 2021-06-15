using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject tank;
    public Vector3 spawnPos = new Vector3();
    public float startDelay = 0f;
    public float repeatDelay = 2f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnTank1", startDelay, repeatDelay);
        InvokeRepeating("SpawnTank2", startDelay + 1, repeatDelay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnTank1()
    {
        spawnPos = new Vector3(Random.Range(-7,7),2.1f, 154);
        Instantiate(tank, spawnPos, tank.transform.rotation);
    }
    void SpawnTank2()
    {
        spawnPos = new Vector3(Random.Range(-7, 7), 2.1f, 154);
        Instantiate(tank, spawnPos, tank.transform.rotation);
    }
}
