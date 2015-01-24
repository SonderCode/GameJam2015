using UnityEngine;
using System.Collections;

public class GameControllerCleanUp : MonoBehaviour {

	// Use this for initialization
	void Start () {

			if(GameObject.Find("Game Controller") != null)
			Destroy(GameObject.Find("Game Controller"));
	}
	
}
