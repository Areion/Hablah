﻿using UnityEngine;
using System.Collections;

public class TriggerPlate : MonoBehaviour {
	
	public Light sun; // assign sun in inspector
	
	// Use this for initialization
	void Start () {
		light.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter() {
		
		light.enabled = true;
		sun.enabled = false;
	}
}
