using UnityEngine;
using System.Collections;

public class RaycastReception : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate() {
		RaycastHit2D hit = Physics2D.Raycast(transform.position, -Vector2.up);

		Debug.DrawRay(transform.position, Vector2.up, Color.red, Mathf.Infinity);

		if (hit.collider != null) {

			Debug.Log("Hit " + hit.transform.name);
		}
	}
}
