using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	void OnGUI () {

	GUI.contentColor = Color.yellow;
	if (GUI.Button(new Rect(Screen.width/2 -40,Screen.height/2 +50,100,30),"Play")) {
		Application.LoadLevel(1);
	}


	if (GUI.Button(new Rect(Screen.width/2 -40,Screen.height/2 +100,100,30),"Settings")) {
	Application.LoadLevel(5);
}

	if (GUI.Button(new Rect(Screen.width/2 -40,Screen.height/2 +150,100,30),"Quit")) {
		Application.Quit();
}

}
}
