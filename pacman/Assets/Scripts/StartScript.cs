using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	void OnGUI () {
		// Retry starter spillet forfra
	GUI.contentColor = Color.yellow;
	if (GUI.Button(new Rect(Screen.width/2 -40,Screen.height/2 +50,100,30),"Play")) {
		Application.LoadLevel(1);
	}

		//Exit button
	if (GUI.Button(new Rect(Screen.width/2 -40,Screen.height/2 +100,100,30),"Settings")) {
	Application.LoadLevel(5);
}

}
}
