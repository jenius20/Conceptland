using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PseudoMoveLeftAndRight : MonoBehaviour
{
    public Vector2 speed = Vector2.one;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        GetComponent<Renderer>().material.mainTextureOffset += Input.GetAxis("Horizontal") * speed * Time.deltaTime;
    }
}
