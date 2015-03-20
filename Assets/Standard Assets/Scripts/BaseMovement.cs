using UnityEngine;
using System.Collections;

public class BaseMovement : MonoBehaviour {

	public float speed = .15f;

	// Use this for initialization
	void Start () {
		
	}

	void FixedUpdate () {
		transform.position = new Vector3 ( transform.position.x, transform.position.y, transform.position.z - speed); 
	}
}
