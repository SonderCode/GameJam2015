using UnityEngine;
using System.Collections;

public class RandomMovement : MonoBehaviour {

	public float speed = 5.0f;

	public void Start(){

	}
	
	public void Update() {

		MoveBug ();
		SpeedUpBug ();
	}

	public void MoveBug()
	{
		transform.position += transform.up*speed*Time.deltaTime;
	}

	public void SpeedUpBug()
	{
		if(Input.GetKeyDown(KeyCode.Space))
		{
			speed += 0.1f;
		}

		speed += Input.acceleration.z;
	}



}
