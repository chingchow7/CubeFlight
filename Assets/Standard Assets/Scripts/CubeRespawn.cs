using UnityEngine;
using System.Collections;

public class CubeRespawn : MonoBehaviour {

	public GameObject playerBase;

	/*
	public float cubeXLimit = 20f;
	public float cubeZLimit = 60f;
	public float cubeUpperLimit = 20f;
	public float cubeLowerLimit = 30f;*/


	private float cubeXLimit = 70f;
	private float cubeZLimit = 100f;
	private float cubeUpperLimit = 60f;
	private float cubeLowerLimit = 60f;


	// Use this for initialization
	void Start () {
		//playerBase = GameObject.Find ("PlayerBase");
	}
	
	// Update is called once per frame
	void Update () {

		// respawn cube if they pass the paramter
		if ( (transform.position.z > playerBase.transform.position.z ) ||
		     (transform.position.y < (playerBase.transform.position.y - cubeLowerLimit)) ||
		     (transform.position.y > (playerBase.transform.position.y + cubeUpperLimit)) ||
		     (transform.position.x > (playerBase.transform.position.x + cubeXLimit)) ||
		     (transform.position.x < (playerBase.transform.position.x - cubeXLimit))
		    ) {
			Respawn ();
		}

		if (!this.GetComponent<Renderer>().isVisible) {
			Respawn ();
		}
	}

	public void Respawn () {
		float newXPos;
		float newYPos;
		float newZPos;
		playerBase = GameObject.Find ("PlayerBase");

		newXPos = Random.Range ( playerBase.transform.position.x - cubeXLimit, playerBase.transform.position.x + cubeXLimit);
		newYPos = Random.Range ( playerBase.transform.position.y - cubeLowerLimit,  playerBase.transform.position.y + cubeUpperLimit);
		newZPos = Random.Range ( playerBase.transform.position.z - cubeZLimit - 20, playerBase.transform.position.z - cubeZLimit + 50);

		transform.position = new Vector3 ( newXPos, newYPos, newZPos);
	}
}
