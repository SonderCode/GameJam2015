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
		Vector3 temPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		LightToMove.transform.position = temPos;
	}
}
