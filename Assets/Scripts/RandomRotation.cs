﻿using UnityEngine;
using System.Collections;

public class RandomRotation : MonoBehaviour {

	private Rigidbody rb;
	public float tumble;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		rb.angularVelocity = Random.insideUnitSphere * tumble;
	}
	

}
