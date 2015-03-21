using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour {

	private float cubeSpawnLimit = 650f;

	// Use this for initialization
	void Start () {
	
		for ( int i = 0; i < cubeSpawnLimit; i++) {
			GameObject cube = (GameObject)Instantiate(Resources.Load("RedCube"));
			cube.GetComponent<CubeRespawn>().Respawn();

			cube = (GameObject)Instantiate(Resources.Load("WhiteCube"));
			cube.GetComponent<CubeRespawn>().Respawn();
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
