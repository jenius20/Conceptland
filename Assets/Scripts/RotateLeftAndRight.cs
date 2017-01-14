using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLeftAndRight : MonoBehaviour
{
    public Vector3 direction;
    public Vector3 anchorPoint;


    public float tiltPerSecond = 1.0f;

 
        
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.RotateAround(anchorPoint, direction * Input.GetAxis("Horizontal"), tiltPerSecond * Time.deltaTime);
	}
}
