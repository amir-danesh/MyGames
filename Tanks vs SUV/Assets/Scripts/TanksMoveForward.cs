using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TanksMoveForward : MonoBehaviour
{
    public float speed = 35;
    public float leftBound = -70.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if (transform.position.z < leftBound)
        {
            Destroy(gameObject);
        }
    }
}
