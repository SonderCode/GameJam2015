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
		RayKiller ();
	}

	void GetHitPoint()
	{
		var mousePos = Input.mousePosition;

		mousePos.z = 7; // select distance = 10 units from the camera

		Vector3 temPos = Camera.main.ScreenToWorldPoint (mousePos);

		LightToMove.transform.position = temPos;
	}

	void RayKiller()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if (Physics.Raycast(ray, out hit))
		{
			hit.transform.localScale -= new Vector3(0.01f,0.01f,0.01f);
		}
    }
}
