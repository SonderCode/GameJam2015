using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour
{

	public int targetAmount;
	public Text textBox;
	public static int BalloonCount
	{
		get;
		set;
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
		if(BalloonCount >= targetAmount)
		{
			textBox.text = "Target Balloon amount achieved";
		}
	}
}
