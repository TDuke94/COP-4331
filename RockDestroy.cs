﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockDestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D other)
	{
		//if (other.tag == "Boundary")
		//	return;
		//Destroy (other.gameObject);
		Destroy (gameObject);
		GUI.Label (new Rect (0, 0, 500, 500), "YOOOOO bitch");
	}
}
	
