﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jetarrows : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.UpArrow)) {
			this.transform.Translate (0, 1.5f, 0);
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			this.transform.Translate (0, -1.5f, 0); 
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			this.transform.Translate (1.5f, 0, 0);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			this.transform.Translate (-1.5f, 0, 0);
		}
		
	
	}
}