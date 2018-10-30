using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class BlockAssigner : MonoBehaviour {


	public string block; 
	public Flowchart flow;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay2D(Collider2D col) {


		if (Input.GetMouseButtonDown (0)){
			flow.ExecuteBlock(block);
			Debug.Log ("Test");
		}
	}
}
