using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FindTheMonster : MonoBehaviour
{
	
	public int Round;
	public int DiffLevel = 3;

	public Camera SeanCam;

	public GameObject MonsterSprite;
	public bool MonsterHit = false;

	private float Timer;
	public float RoundedTimer;
	public float CompletionTime = 1.0f;
	public float PlayerTime;

	private float RandomNumber;
	public float RoundedRandomNumber;

	Text text;

	public void Awake()
	{
		Difficulty ();
		MonsterSprite.SetActive (false);
		RandomNumber = (Random.Range (0.0F, 10.0F));
		RoundedRandomNumber = Mathf.Round (RandomNumber);
		PlayerTime = RoundedRandomNumber + CompletionTime;

	}
	public void Start()
	{
		RandomPosition ();
	}
	public void Update()
	{
		DestroyMonster();
		RandomTimer ();
		GameOutcome ();
	}
	public void DestroyMonster()
	{
		Ray ray = SeanCam.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		
		if(Physics.Raycast(ray,out hit))
		{
			if(Input.GetMouseButtonDown(0) && hit.transform.tag == "Monster")
			{
				MonsterHit = true;
				Destroy(hit.collider.gameObject);
			}
		}
	}
	public void RandomTimer()
	{
		Timer += 1 * Time.deltaTime;
		RoundedTimer = Mathf.Round (Timer);

		if (RoundedTimer == RoundedRandomNumber) 
		{
			MonsterSprite.SetActive(true);
		}
	}
	public void RandomPosition()
	{
		MonsterSprite.transform.position = new Vector3(Random.Range(-3.0F, 3.0F), Random.Range(-5.0F, 5.0F), 0);
	}
	public void GameOutcome()
	{
		if (MonsterHit == true) 
		{
			Application.LoadLevel("WinScreen");
		}
		if (RoundedTimer == PlayerTime) 
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
			CompletionTime = 1.0F;
		}
		if (DiffLevel == 2) 
		{
			CompletionTime = 0.5F;
		}
		if (DiffLevel == 3) 
		{
			CompletionTime = 0.25F;
		}
	}
}
