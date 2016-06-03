﻿using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	// Change time to destroy bullets here
	float destructTime = 5.0f;
	public GameObject explosion;
	
	// Use this for initialization
	void Start () {
		Destroy(gameObject, destructTime);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision col){
		var exp = Instantiate(explosion, transform.position, transform.rotation) as GameObject;
		Destroy (exp, 1f);
		Destroy (gameObject);
	}
}