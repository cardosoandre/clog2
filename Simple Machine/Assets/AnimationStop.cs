using UnityEngine;
using System.Collections;

public class AnimationStop : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("space") == true) {
			gameObject.GetComponent<Animator> ().enabled = false;
		}
	
	}
}
