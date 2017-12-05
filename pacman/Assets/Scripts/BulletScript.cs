using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {
//public Transform spawnPoint;
	public float velX = 5F;
	public float velY = 5f;
				Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();

	}

	// Update is called once per frame
	void Update () {
		rb.velocity = new Vector2(velX, velY);

	}

	//void OnTriggerEnter2D(Collider2D co) {
	  //  if (co.name == "blinky") {
	    //    Destroy(co.gameObject);
//}
					//if (co.name == "blinky"){
			      //  co.transform.position =  spawnPoint.position;

			//}
	//}

}
