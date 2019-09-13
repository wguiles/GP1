using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    /*
		 * Warren Guiles
		 * (SprinPropellerX)
		 * (Assignment 3)
		 * (This script, attached to the child propeller object, rotates around it's z axis every frame based on the rotate speed float set in the inspector.)
		 */


    public float rotateSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, 10f * rotateSpeed * Time.deltaTime);
    }
}
