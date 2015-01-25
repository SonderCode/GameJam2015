using UnityEngine;
using System.Collections;

public class SpawnMonsters : MonoBehaviour {

	public GameObject Monsters;
	public int MonsterCount = 10;
	// Use this for initialization
	void Start () {
		
		for(int i = 0; i < MonsterCount; i++)
		{
			Instantiate(Monsters, Monsters.transform.position + new Vector3(Random.Range(-3.5f,3.5f),
			                                                        Random.Range(-3.5f,3.5f),0), Monsters.transform.rotation );
		}
	}

}
