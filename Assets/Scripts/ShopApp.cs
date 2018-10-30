using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class ShopApp : MonoBehaviour {

	public Flowchart flow;
	public int shopInt = 1;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D () {
		flow.SetIntegerVariable ("ShopInt", shopInt); 
	}
}
