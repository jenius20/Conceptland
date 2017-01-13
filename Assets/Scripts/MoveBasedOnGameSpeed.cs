﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBasedOnGameSpeed : MonoBehaviour
{
    public Vector3 direction = Vector3.forward;
    public float speed = 1.0f;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position += transform.rotation * (direction.normalized * GameManager.Instance.gameSpeed * Time.deltaTime);
	}
}
