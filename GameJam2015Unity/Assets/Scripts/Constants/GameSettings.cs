using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameSettings : MonoBehaviour {

	public int PlayerCount = 0;
	public int PuzzlePlayedCount = 0;
	public int RoundCount = 0;
	public float TimeRemaining = 10;

	public Text CountdownText;
	// Use this for initialization

	void Awake()
	{
		DontDestroyOnLoad (transform.gameObject);
	}

	// Update is called once per frame
	void Update () {

		if(CountdownText != null)
		CountdownTheTime();
	}

	void CountdownTheTime()
	{
		CountdownText.text = TimeRemaining.ToString();
		TimeRemaining -= Time.deltaTime;
	}
}
