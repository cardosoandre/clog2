using UnityEngine;
using System.Collections;

public class playlittlesound : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter (Collider other) {
		gameObject.GetComponent<AudioSource>().Play();
	}
	
}
