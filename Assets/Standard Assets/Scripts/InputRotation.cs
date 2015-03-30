using UnityEngine;
using System.Collections;

public class InputRotation : MonoBehaviour {

	// input variables
	private float x_input;
	private float y_input;
	
	// speed of movement
	private float x_angle;
	private float y_angle;

	private float x_angle_max = 35f;
	private float y_angle_max = 35f;
	
	// Update is called once per frame
	void Update () {
		
		//get input
		x_input = Input.GetAxis ("Horizontal");
		y_input = Input.GetAxis ("Vertical");
		
		//output input for debug
		//Debug.Log ( x_input + " and " + y_input);
	}

	// handle rotation based on input
	void FixedUpdate () {
		x_angle = -1f * x_input * x_angle_max;
		y_angle = 90f + -1f*(y_input * y_angle_max);
		
		//transform.eulerAngles = new Vector3 ( y_angle, 0f, transform.rotation.z + x_angle_max);
		//transform.rotation = Quaternion.Euler( y_angle, 0f, x_angle);

		Quaternion target = Quaternion.Euler(y_angle, 0, x_angle);
		transform.rotation = Quaternion.Slerp(transform.rotation, target, 5f);
	}
}
