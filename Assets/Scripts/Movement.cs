using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {


	Rigidbody2D rb; 
	public AudioSource aud;
	[Range (0,20)]
	public float speed;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		//aud = Get
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.A)) {
			transform.Translate (Vector3.left * speed * Time.deltaTime);
		}

		if (Input.GetKey (KeyCode.D)) {
			transform.Translate (Vector3.right * speed * Time.deltaTime);
		}

		if (Input.GetMouseButtonDown (0)) {
			aud.pitch -= .1f;
		}
	}

	void OnTriggerEnter2D () {
		Debug.Log ("Hello");
	}
}
