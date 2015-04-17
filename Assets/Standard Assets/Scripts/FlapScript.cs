using UnityEngine;
using System.Collections;

public class FlapScript : MonoBehaviour {
	
	public float flapSpeed = 100f;

	bool didFlap = false;
	Rigidbody rigidbody_;

	// Use this for initialization
	void Start () {
		rigidbody_ = GetComponent<Rigidbody>();
	}
	
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space) || Input.GetMouseButtonDown(0)) {
			didFlap = true;
		}
	}

	void FixedUpdate () {
		if (didFlap) {
			rigidbody_.AddForce( Vector3.up * flapSpeed);
			
			didFlap = false;
		}
		/*
		if(rigidbody_.velocity.y > 0) {
			transform.rotation = Quaternion.Euler(0, 0, 0);
		}
		else {
			float angle = Mathf.Lerp (0, -90, (-rigidbody_.velocity.y / 3f) );
			transform.rotation = Quaternion.Euler(0, 0, angle);
		}*/
	}
}
