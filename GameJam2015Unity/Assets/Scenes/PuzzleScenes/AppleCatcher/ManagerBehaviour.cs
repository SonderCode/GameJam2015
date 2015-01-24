using UnityEngine;
using System.Collections;

public class ManagerBehaviour : MonoBehaviour {

	public GameObject basket;
	public GameObject apple;

	public float gameMultiplier = 1; // increase this to make level more difficult (i.e. 1.2f, 2, etc based on design)

	float endTime = 5;
	public bool failed = false;

	// Use this for initialization
	void Start () {
		//GameObject go = GameObject.Instantiate ("apple copy");
		
		float randomX = Random.Range (-5.53f, 5.53f);
		
		Instantiate (apple, new Vector2(randomX, apple.transform.position.y), Quaternion.identity);

		StartCoroutine (DropApple());
	}
	
	IEnumerator DropApple() {
		yield return new WaitForSeconds(0.6f * gameMultiplier);

		float randomX = Random.Range (-5.53f, 5.53f);

		Instantiate (apple, new Vector2(randomX, apple.transform.position.y), Quaternion.identity);
		
		StartCoroutine (DropApple());
	}
	
	// Update is called once per frame
	void Update () {
		endTime -= UnityEngine.Time.deltaTime;

		if (endTime <= 0) {
			// minigame end - show SUCCESS message here
		}
	}

	void OnGUI() {
		if (failed) {
			// minigame FAIL
			GUI.Label (new Rect (10, 10, 400, 40), "FAIL!!! :(");
		} else if (endTime <= 0) {
			// minigame SUCCESS
			GUI.Label (new Rect (10, 10, 400, 40), "SUCCESS!!! :D");
		} else {
			GUI.Label (new Rect (10, 10, 400, 40), endTime.ToString());
		}
	}
}
