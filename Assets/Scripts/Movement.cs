﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class Movement : MonoBehaviour {


	Rigidbody2D rb; 
	public AudioSource aud;
	Animator anim;
	[Range (0,20)]
	public float speed;
    public Flowchart flow;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.A)) {
			transform.Translate (Vector3.left * speed * Time.deltaTime);
			anim.SetBool ("FacingRight", false);
			anim.SetBool ("Moving", true);
		} else if (Input.GetKey (KeyCode.D)) {
			transform.Translate (Vector3.right * speed * Time.deltaTime);
			anim.SetBool ("FacingRight", true);
			anim.SetBool ("Moving", true);
		} else {
			anim.SetBool ("Moving", false);
		}

		//if (Input.GetMouseButtonDown (0)) {
		//	aud.pitch -= .02f;
		//}
	}


    void OnTriggerStay2D() {
        Debug.Log("Hello");

        if (Input.GetKeyDown (KeyCode.E)){
            flow.ExecuteBlock("Little Girl V1");

          }
	}

}
