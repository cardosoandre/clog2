﻿using UnityEngine;
using System.Collections;

public class AnimationTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter (Collider other) {
			GameObject.Find("Main Camera").GetComponent<Animator>().enabled = true;
		}

}

 