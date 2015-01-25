using UnityEngine;
using System.Collections;

public class SateliteBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//Debug.Log ("satellite created");
	}

	bool dragging = false;
	bool colliding = false;
	float endTime = 5;
	float collisionSecondsMax = 2;
	float collisionSeconds = 0;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("Fire1")) {
			dragging = true;
		} else {
			dragging = false;
		}

		if (dragging) {
			Vector3 tempWorldPosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			Vector2 tempTouchPos = new Vector2 (tempWorldPosition.x, tempWorldPosition.y);
	
			gameObject.transform.position = new Vector3 (tempTouchPos.x, gameObject.transform.position.y, gameObject.transform.position.z);
		}

		if (colliding) {
			collisionSeconds += UnityEngine.Time.deltaTime;
			if (collisionSeconds >= collisionSecondsMax) {
				// minigame SUCCESS
				collisionSeconds = collisionSecondsMax;
			}
			
			float energyBarWidthMult = collisionSeconds / collisionSecondsMax;
			int energiesToShow = (int) Mathf.Floor(energyBarWidthMult / 0.125f);

			GameObject.FindWithTag("phonesignalmanager").GetComponent<PhoneSignalManagerBehaviour>().UpdatePhoneEnergies(energiesToShow);
		}

		endTime -= UnityEngine.Time.deltaTime;
		if (endTime <= 0) {
			// minigame FAIL
		}
	}

	void OnTriggerEnter2D(Collider2D collider) {
		if (collider.gameObject.tag == "wave") {
			colliding = true;
		}
	}

	void OnTriggerExit2D(Collider2D collider) {
		if (collider.gameObject.tag == "wave") {
			colliding = false;
		}
	}
}
