using UnityEngine;
using System.Collections;

public class AppleBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	public ManagerBehaviour manager;

	// Update is called once per frame
	void Update () {
		if (gameObject.transform.position.y <= -5.9) {
			GameObject.FindWithTag("manager").GetComponent<ManagerBehaviour>().failed = true;
		}
	}
}
