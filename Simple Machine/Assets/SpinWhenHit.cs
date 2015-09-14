using UnityEngine;
using System.Collections;

public class SpinWhenHit : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter (Collider other) {
		gameObject.GetComponent<Animator> ().enabled = true;
	}
}
