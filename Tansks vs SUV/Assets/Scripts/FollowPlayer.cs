using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Game object and the offsets for cameras
    public GameObject player;
    public Vector3 offset = new Vector3(0, 5, -7);

    /* Call this function to disable IVC camera,
     * and enable OVC camera */

    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector3(0, 5, -7);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
