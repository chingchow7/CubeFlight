using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	// speed modifiers
	public float x_speed_mod = .5f;
	public float y_speed_mod = .5f;

	// input variables
	private float x_input;
	private float y_input;

	// speed of movement
	private float x_speed;
	private float y_speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//get input
		x_input = Input.GetAxis ("Horizontal");
		y_input = Input.GetAxis ("Vertical");

		//output input for debug
		//Debug.Log ( x_input + " and " + y_input);
	}

	// Handle physics based on input
	void FixedUpdate () {
		x_speed = x_input * x_speed_mod;
		y_speed = y_input * y_speed_mod;

		transform.Translate( new Vector3( x_speed, y_speed, 0));
	}
}
