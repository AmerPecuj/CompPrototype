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
		GUI.contentColor = Color.yellow;
		if (GUI.Button(new Rect(Screen.width/2 -50,Screen.height/2 +50,100,30),"Retry?")) {
			Application.LoadLevel(1);
		}

		//Exit button
		if (GUI.Button(new Rect(Screen.width/2 -50,Screen.height/2 +100,100,30),"Quit")) {
		Application.Quit();
	}
  }
}
