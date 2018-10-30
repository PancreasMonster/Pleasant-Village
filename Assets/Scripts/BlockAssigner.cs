using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class BlockAssigner : MonoBehaviour {


	public string block; 
	public Flowchart flow;
	public Sprite sprite1, sprite2;
	SpriteRenderer sr;

	// Use this for initialization
	void Start () {
		sr = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (flow.GetIntegerVariable ("ShopInt") > 1 && flow.GetIntegerVariable ("ShopInt") < 4) {
			sr.sprite = sprite1;
		} else if (flow.GetIntegerVariable ("ShopInt") == 4) {
			sr.sprite = sprite2;
		}
	}

	void OnTriggerStay2D(Collider2D col) {


		if (Input.GetKeyDown (KeyCode.E)){
			flow.ExecuteBlock(block);
			Debug.Log ("Test");
		}
	}
}
