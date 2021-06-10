using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 25.0f;
    public float xRange = 15.0f;
    public float zUpperRange = 15.0f;
    public float zLowerRange = 0.0f;

    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.z > zUpperRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zUpperRange);
        }
        else if (transform.position.z < zLowerRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zLowerRange);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * Time.deltaTime * horizontalInput * speed);
        transform.Translate(Vector3.forward * Time.deltaTime * verticalInput * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Launch a projectile from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
