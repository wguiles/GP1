using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
        /*
		 * Warren Guiles
		 * (FollowPlayerX)
		 * (Assignment 3)
		 * (This script adjusts the camera every frame to follow the gameObject
          that is the "plane" object)
		 */

    public GameObject plane;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
       offset = new Vector3(30, 0, 10);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = plane.transform.position + offset;
    }
}
