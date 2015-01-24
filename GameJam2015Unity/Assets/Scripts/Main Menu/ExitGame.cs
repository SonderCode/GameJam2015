using UnityEngine;
using System.Collections;

public class ExitGame : MonoBehaviour {

	public void ExitTheGame()
	{
		#if UNITY_EDITOR
		Debug.Log ("Quit");
		#endif
		Application.Quit();
	}

}
