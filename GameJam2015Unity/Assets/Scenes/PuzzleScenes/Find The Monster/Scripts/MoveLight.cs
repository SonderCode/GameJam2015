using UnityEngine;
using System.Collections;

public class MoveLight : MonoBehaviour {
	public GameObject LightToMove;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GetHitPoint ();
	}

	void GetHitPoint()
	{
		var mousePos = Input.mousePosition;

		mousePos.z = 7; // select distance = 10 units from the camera

		Debug.Log(Camera.main.ScreenToWorldPoint(mousePos));

		Vector3 temPos = Camera.main.ScreenToWorldPoint (mousePos);

		LightToMove.transform.position = temPos;
	}
}
