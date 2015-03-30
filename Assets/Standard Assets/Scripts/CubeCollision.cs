using UnityEngine;
using System.Collections;

public class CubeCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter (Collider col) {
		//Debug.Log ( " HIT TRIGGER " + col.gameObject.name);

		if(col.gameObject.tag == "Player")
		{
			Debug.Log ("HIT");
		}
	}
}
