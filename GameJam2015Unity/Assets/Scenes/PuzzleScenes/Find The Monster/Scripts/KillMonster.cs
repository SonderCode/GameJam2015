using UnityEngine;
using System.Collections;

public class KillMonster : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {

		if (gameObject.transform.localScale.x < 0.05f)
						Destroy (gameObject);
	
	}
}
