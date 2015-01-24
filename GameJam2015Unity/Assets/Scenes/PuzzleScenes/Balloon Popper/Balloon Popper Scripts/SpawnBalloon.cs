using UnityEngine;
using System.Collections;

public class SpawnBalloon : MonoBehaviour
{
	public GameObject balloonPrefab;
	public int spawnTime;
	public int spawnAmount;
	// Use this for initialization
	void Start () 
	{
		for(int i = 0; i < spawnAmount; i++)
		{
			Instantiate (balloonPrefab, 
			             new Vector3(Random.Range(-5f, 10.5f), 
			                         Random.Range(-5.5f, 6), 
			                         Random.Range(-5, 10)) + this.gameObject.transform.collider.bounds.extents, 
			            Quaternion.identity);
		}

	}
	
	void SpawnTimer()
	{
		spawnTime = Random.Range (1, 150);
	}
}
