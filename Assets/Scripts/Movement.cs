using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {


	Rigidbody2D rb; 
	[Range (0,20)]
	public float speed;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.A)) {
			rb.AddForce (Vector2.left * speed * Time.deltaTime);
		}
	}
}
