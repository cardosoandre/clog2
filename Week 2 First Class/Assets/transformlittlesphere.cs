using UnityEngine;
using System.Collections;

public class transformlittlesphere : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log (gameObject.transform.position);
		gameObject.transform.position = new Vector3 ( 3f, 3f, 3f);
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.position = 
			gameObject.transform.position + new Vector3 (.01f, .01f, 0);
	
	}
}
