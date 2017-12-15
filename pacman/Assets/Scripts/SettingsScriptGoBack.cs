using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsScriptGoBack : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	void OnGUI () {
		GUI.contentColor = Color.yellow;
		//Go back button
	if (GUI.Button(new Rect(Screen.width/2 -40,Screen.height/2 +100,100,30),"Back")) {
	Application.LoadLevel(0);
}

}
}
