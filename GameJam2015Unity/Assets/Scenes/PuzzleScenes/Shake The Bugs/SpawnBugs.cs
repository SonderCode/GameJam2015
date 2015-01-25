using UnityEngine;
using System.Collections;

public class SpawnBugs : MonoBehaviour {

	public GameObject Bugs;
	// Use this for initialization
	void Start () {
	
		for(int i = 0; i < 10; i++)
		{
			Quaternion RandomRotation;
			RandomRotation = Quaternion.Euler(new Vector3(0,0,Random.Range(0,360)));

			Instantiate(Bugs, Bugs.transform.position + new Vector3(Random.Range(-5,5),
			                                                        Random.Range(-5,5),0), RandomRotation );
		}
	}

}
