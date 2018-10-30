using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class Movement : MonoBehaviour {


	Rigidbody2D rb; 
	public AudioSource aud;
	[Range (0,20)]
	public float speed;
    public Flowchart flow;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.A)) {
			transform.Translate (Vector3.left * speed * Time.deltaTime);
		}

		if (Input.GetKey (KeyCode.D)) {
			transform.Translate (Vector3.right * speed * Time.deltaTime);
		}

		//if (Input.GetMouseButtonDown (0)) {
		//	aud.pitch -= .02f;
		//}
	}

<<<<<<< HEAD
    void OnTriggerStay2D() {
        Debug.Log("Hello");

        if (Input.GetKeyDown (KeyCode.E)){
            flow.ExecuteBlock("Little Girl V1");

          }
	}
=======
    
>>>>>>> 745d9bb9fb6d7cea89629acc1e6045be7347e446
}
