using UnityEngine;
using System.Collections;

public class ChangeSceneTo : MonoBehaviour {

	public void SwapSceneName(string Scenename)
	{
		Application.LoadLevel(Scenename);
	}

	public void SwapSceneNumber(int Scenenumber)
	{
		Application.LoadLevel(Scenenumber);
	}
}
