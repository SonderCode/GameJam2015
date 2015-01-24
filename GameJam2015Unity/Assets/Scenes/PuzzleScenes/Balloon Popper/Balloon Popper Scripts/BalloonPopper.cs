using UnityEngine;
using System.Collections;

public class BalloonPopper : MonoBehaviour {

	// Use this for initialization
	void OnCollisionEnter (Collision col)
	{
		Destroy(col.gameObject);
	}
}
