﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayHighscore : MonoBehaviour
{
    private string label;

	// Use this for initialization
	void Start ()
    {
        TextMesh textMesh = GetComponent<TextMesh>();
        label = textMesh.text;
        textMesh.text = label + PlayerPrefs.GetInt("Highscore");
	}
	
}
