using UnityEngine;
using System.Collections;

public class BasketBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		/*
		if (Input.touchCount > 0) {
			gameObject.transform.position = new Vector2(Input.GetTouch (0).position.x, Input.GetTouch(0).position.y);

			if (Input.GetTouch (0).phase == TouchPhase.Began || Input.GetTouch (0).phase == TouchPhase.Moved) {
				Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
				Vector2 touchPos = new Vector2(worldPosition.x, worldPosition.y);

				if (Physics2D.OverlapPoint(touchPos) == collider2D) {
					gameObject.transform.position = new Vector2(Input.GetTouch (0).position.x, Input.GetTouch(0).position.y);
				}
			}
		}
		*/

		if (Input.GetButton ("Fire1")) {
			dragging = true;
		} else {
			dragging = false;
		}
		
		if (dragging) {
			Vector3 tempWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Vector2 tempTouchPos = new Vector2(tempWorldPosition.x, tempWorldPosition.y);
			
			gameObject.transform.position = new Vector3 (tempTouchPos.x, tempTouchPos.y, gameObject.transform.position.z);
		}
	}
	
	bool dragging = false;
	void OnMouseDown() {
		//dragging = true;
	}
	void OnMouseUp() {
		//dragging = false;
	}

	void OnTriggerEnter2D(Collider2D collider) {
		if (collider.gameObject.tag == "apple") {
			Destroy(collider.gameObject);
		}
	}
}
