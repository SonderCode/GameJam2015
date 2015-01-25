using UnityEngine;
using System.Collections;

public class WaveBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	public float gameMultiplier = 1; // increase this to make level more difficult (i.e. 1.2f, 2, etc based on design)

	int direction = 1; // -1 for left, 1 for right

	// Update is called once per frame
	void Update () {
		//return;
		gameObject.transform.Rotate (0, 0, -1.0f * direction * gameMultiplier);

		if (gameObject.transform.rotation.z <= -0.4f || gameObject.transform.rotation.z >= 0.4f) {
			direction = -direction;
		}

		gameObject.transform.position = new Vector3 (gameObject.transform.position.x + 0.0001f, gameObject.transform.position.y, gameObject.transform.position.z);
	}
}
