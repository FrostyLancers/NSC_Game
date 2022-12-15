using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //public Transform target; // The object to follow
    //public float smoothSpeed = 0.125f; // The speed with which the camera will follow
    public Transform target; // The object that the camera should follow

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Set the position of the camera to match the target object
        //transform.position = target.position;
        transform.position = target.position;
    }
}
