using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    public float jumpForce = 10.0f;
    public bool onTheGround = true;
    public float horizontalInput;
    public float verticalInput;
    public float zBound = 6.0f;
    private Rigidbody playerRb;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        PreventGoingOutOfScreen();
    }
    // Moving player
    void MovePlayer()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        playerRb.AddForce(Vector3.forward * speed * verticalInput);
        playerRb.AddForce(Vector3.right * speed * horizontalInput);

        if (Input.GetKeyDown(KeyCode.Space) && onTheGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            onTheGround = false;
        }
    }
    // Prevent the player to go outside the screen (bottom and top boundries)
    void PreventGoingOutOfScreen()
    {
        if (transform.position.z < -6)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zBound);
        }
        else if (transform.position.z > 6)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zBound);
        }
        if (transform.position.y == 0.5)
        {
            onTheGround = true;
        }
    }
}
