using UnityEngine;
using System.Collections;

public class PhoneSignalManagerBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	public GameObject[] phoneEnergies;

	// Update is called once per frame
	void Update () {
	
	}

	public void UpdatePhoneEnergies(int energiesToShow) {
		for (int i = 0; i < energiesToShow; i ++) {
			if (! phoneEnergies[i].renderer.enabled) {
				phoneEnergies[i].renderer.enabled = true;
			}
		}
	}
}
