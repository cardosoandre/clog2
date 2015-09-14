using UnityEngine;
using System.Collections;

public class forcepusher : MonoBehaviour {

	private float xForce;
	private GameObject BlueCube;

	// Use this for initialization
	void Start () {
		xForce = 150;
		BlueCube = GameObject.Find("BlueCube"); 
	}
	
	// Update is called once per frame
	void Update () {
		// when I hit the key space, move the object
		// if I hit the space 
		// if (the Space key is pressed) 
		if (Input.GetKey ("joystick button 1") == true) {
			gameObject.GetComponent<Rigidbody> ().AddForce (new Vector3 (xForce, 0, 0));
			gameObject.GetComponent<Rigidbody> ().AddTorque (new Vector3 (0, 0, 150));
			BlueCube.transform.localScale = BlueCube.transform.localScale + new Vector3 ( 0.1f, 0.1f, 0.1f);
		}

		if (Input.GetKey ("joystick button 0") == true) {
			gameObject.GetComponent<Rigidbody> ().AddForce (new Vector3 (-150, 0, 0));
			gameObject.GetComponent<Rigidbody> ().AddTorque (new Vector3 (0, 0, -150));
			BlueCube.transform.localScale = BlueCube.transform.localScale - new Vector3 ( 0.1f, 0.1f, 0.1f);
		}
	}
}