using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class ShopApp : MonoBehaviour {

	public Flowchart flow;
	public int shopInt = 1;
	public BoxCollider2D self, other; 
	public AudioSource aud; 
	public Animator anim;
	public Movement move;

	// Use this for initialization
	void Start () {
		self = GetComponent<BoxCollider2D> ();
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D () {
		flow.SetIntegerVariable ("ShopInt", shopInt); 
		shopInt += 2; 
		self.enabled = false; 
		other.enabled = true; 
		aud.pitch -= .2f;
		StartCoroutine (FadeScene ());
	}

	IEnumerator FadeScene() {
		anim.SetBool ("Fade", true);
		move.enabled = false; 
		yield return new WaitForSeconds (1f);
		anim.SetBool ("Fade", false);
		move.enabled = true; 
	}
}
