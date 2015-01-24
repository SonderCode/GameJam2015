using UnityEngine;
using System.Collections;

public class TouchControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Began) 
		{
			Ray ray = Camera.main.ScreenPointToRay( Input.GetTouch(0).position );
			RaycastHit hit;
			
		

			if ( Physics.Raycast(ray, out hit, 100f ) )
			{
				Destroy(hit.collider.gameObject);
				GameController.BalloonCount += 1;
				//Debug.Log(hit.transform.gameObject.name);
			}
		}
	}
}
