using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Manager : MonoBehaviour 
{	
	public int FillTotal = 100;
	public int FillAmount = 5;
	public int FillBalloon = 0;

	public GameObject Balloon1;
	public GameObject Balloon2;
	public GameObject Balloon3;
	public GameObject Balloon4;

	public int Round;
	public int DiffLevel = 3;

	public Camera SeanCam;
	
	public float CountDown = 10;
	public GameObject Count;
	
	Text text;

	public void Awake()
	{
		Difficulty ();
	}

	public void Start()
	{
		text = Count.GetComponent <Text> ();

		Balloon1.SetActive(true);
		Balloon2.SetActive(false);
		Balloon3.SetActive(false);
		Balloon4.SetActive(false);
	}
	
	public void Update() 
	{
		Timer ();
		GameOutcome ();
		BalloonIncrease();
	}

	public void ButtonPress()
	{
		FillBalloon += FillAmount;
	}
	public void BalloonIncrease()
	{
		if (FillBalloon == (25)) 
		{
			//ChangeSprite
			Balloon1.SetActive(false);
			Balloon2.SetActive(true);
			Balloon3.SetActive(false);
			Balloon4.SetActive(false);
		}
		if (FillBalloon == (50)) 
		{
			//ChangeSprite
			Balloon1.SetActive(false);
			Balloon2.SetActive(false);
			Balloon3.SetActive(true);
			Balloon4.SetActive(false);
		}
		if (FillBalloon == (75)) 
		{
			//ChangeSprite
			Balloon1.SetActive(false);
			Balloon2.SetActive(false);
			Balloon3.SetActive(false);
			Balloon4.SetActive(true);
		}
	}
	public void Timer()
	{
		CountDown -= 1 * Time.deltaTime;
		if (CountDown <= 0) 
		{
			CountDown = 0;
		}
		text.text = "Time Left: " + CountDown;
	}
	public void GameOutcome()
	{
		if (FillBalloon == FillTotal) 
		{
			Application.LoadLevel("WinScreen");
		}
		
		if (CountDown == 0) 
		{
			Application.LoadLevel("LoseScreen");
		}
	}
	public void Difficulty()
	{
		//Consistent through board games rounds
		if (Round <= 5) 
		{
			DiffLevel = 1;
		}
		if (Round >=6 && Round <= 10)
		{
			DiffLevel = 2;
		}
		if (Round >= 10) 
		{
			DiffLevel = 3;
		}
	
		//How it effects this MiniGame
		if (DiffLevel == 1) 
		{
			FillTotal = 100;
			CountDown = 8;
		}
		if (DiffLevel == 2) 
		{
			FillTotal = 120;
			CountDown = 8;
		}
		if (DiffLevel == 3) 
		{
			FillTotal = 120;
			CountDown = 5;
		}
	}
}