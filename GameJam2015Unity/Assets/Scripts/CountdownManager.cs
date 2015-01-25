using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class CountdownManager : MonoBehaviour {

	public Text countdownClock;
	public float timerAmount = 10f;
	// Use this for initialization
	void Start () {

		countdownClock.text = timerAmount.ToString();
	
	}

	void EndGame ()
	{
		countdownClock.text = "End";
		Application.LoadLevel ("LoseScreen");
	}
	
	// Update is called once per frame
	void Update () {

		timerAmount -= Time.deltaTime;

		if (timerAmount > 10)
			countdownClock.text = timerAmount.ToString ().Substring (0, 2);
		else if (timerAmount > 1)
			countdownClock.text = timerAmount.ToString ().Substring (0, 1);
		else
			EndGame ();

	
	}
}
