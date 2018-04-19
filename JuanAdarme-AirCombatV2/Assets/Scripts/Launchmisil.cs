using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launchmisil : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {

			GameObject GameObject = GameObject.Instantiate (Resources.Load ("Prefabs/PivotMisil") as GameObject); 

			GameObject.transform.SetParent (this.transform);

			GameObject.transform.localPosition = new Vector3 (0, 0, 0);

			GameObject.transform.SetParent (null);
		
	}
	}
}
