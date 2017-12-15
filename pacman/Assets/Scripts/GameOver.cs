using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void OnGUI () {
		// Retry starter spillet forfra
		GUI.contentColor = Color.red;
		if (GUI.Button(new Rect(Screen.width/2 -40,Screen.height/2 +50,80,20),"Retry?")) {
			Application.LoadLevel(1);
		}

		//Exit button
		if (GUI.Button(new Rect(Screen.width/2 -40,Screen.height/2 +80,80,20),"Quit?")) {
		Application.Quit();
	}
  }
}
