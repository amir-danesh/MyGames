using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    public float speed = 10.0f;
    public Material material;
    void Start()
    {
        transform.position = new Vector3(1, 8, 7);
        transform.localScale = Vector3.one * 1.3f;
        
        Material material = Renderer.material;
        
        material.color = new Color(Random.Range(0.0f,1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
    }
    
    void Update()
    {
        transform.position = new Vector3(Random.Range(0.0f,2.0f), Random.Range(0.0f, 2.0f), Random.Range(0.0f, 2.0f));
        material.color = new Color(Random.Range(0.0f,1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
        transform.Rotate(10.0f * Time.deltaTime * speed, 10.0f * Time.deltaTime * speed, 10.0f * Time.deltaTime * speed);
    }
}
