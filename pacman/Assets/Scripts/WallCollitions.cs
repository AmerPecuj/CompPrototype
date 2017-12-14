using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCollitions : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D co) {

	        if (co.name == "bulletToUp(Clone)" || co.name == "bulletToLeft(Clone)" || co.name == "bulletToDown(Clone)" || co.name == "bulletToRight(Clone)"){
	            Destroy(co.gameObject);
	};
	}

}
