using UnityEngine;
using System.Collections;

public class PumpScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		ResetSize();
	}

	void ResetSize()
	{
		if(transform.localScale.x < 10f)
		{
			if (transform.localScale.x > 1.0f)
			{
				transform.localScale -= new Vector3(0.05f,0.05f,0.05f);
			}
		}
		else
		{
			Destroy(transform.gameObject);
		}
	}

	public void ExpandBalloon()
	{
		if(GameObject.Find("Balloon-BlowUp") != null)
		transform.localScale += new Vector3 (0.6f, 0.6f, 0.6f);
	}
}
