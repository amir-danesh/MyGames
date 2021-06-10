using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30.0f;
    private float bottomBound = -30.0f;
    private float rightBound = 30.0f;
    private float leftBound = -30.0f;

    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        // Destroying objects whice go out of the player view to enhance game performance
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < bottomBound || transform.position.x < leftBound || transform.position.x > rightBound)
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
    }
}
