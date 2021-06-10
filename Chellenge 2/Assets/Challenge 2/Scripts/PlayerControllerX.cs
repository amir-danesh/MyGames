using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float timeSinceSpawn;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(timeSinceSpawn >= 1)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                timeSinceSpawn = 0;
            }
        }
        timeSinceSpawn += Time.deltaTime;
    }
}
