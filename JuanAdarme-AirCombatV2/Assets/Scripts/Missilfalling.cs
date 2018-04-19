using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missilfalling : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate (0, 0, 2);
		
	}
		void OnCollisionEnter(Collision collision) {

		//Pregunta la etiqueta del objeto
		if (collision.collider.gameObject.tag == "marsalien") {

			//Carga el PreFab de la explosion
			GameObject Explosion = GameObject.Instantiate (Resources.Load ("Prefabs/marsexplosion") as GameObject); 

			//Posicion en el lugar de impacto
			Explosion.transform.position = collision.collider.gameObject.transform.position;

			Destroy (collision.collider.gameObject);

		//Se destruye el objeto impactado
		Destroy (collision.collider.gameObject);

		//Se destruye el misils
		Destroy (this.gameObject);
		
	}

		if (collision.collider.gameObject.tag == "jupiteralien") {

			//Carga el PreFab de la explosion
			GameObject Explosion = GameObject.Instantiate (Resources.Load ("Prefabs/jupiterexplosion") as GameObject); 

			//Posicion en el lugar de impacto
			Explosion.transform.position = collision.collider.gameObject.transform.position;

			Destroy (collision.collider.gameObject);

			//Se destruye el objeto impactado
			Destroy (collision.collider.gameObject);

			//Se destruye el misils
			Destroy (this.gameObject);
}
}
}
