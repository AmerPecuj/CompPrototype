using UnityEngine;
using System.Collections;

public class GhostMove : MonoBehaviour {
    public Transform[] waypoints;
    int cur = 0;
    public Transform spawnPoint;
    public float speed = 0.3f;

void FixedUpdate () {
    // Waypoint not reached yet? then move closer
    if (transform.position != waypoints[cur].position) {
        Vector2 p = Vector2.MoveTowards(transform.position,
                                        waypoints[cur].position,
                                        speed);
        GetComponent<Rigidbody2D>().MovePosition(p);
    }
    // Waypoint reached, select next one
    else cur = (cur + 1) % waypoints.Length;

    // Animation
    Vector2 dir = waypoints[cur].position - transform.position;
    GetComponent<Animator>().SetFloat("DirX", dir.x);
    GetComponent<Animator>().SetFloat("DirY", dir.y);
}

void OnTriggerEnter2D(Collider2D co) {

    if (co.name == "pacman"){
      Destroy(co.gameObject);
      ExecuteAfterTime(5000);
        Application.LoadLevel(4);
}

    if (co.name == "bulletToUp(Clone)" || co.name == "bulletToLeft(Clone)" || co.name == "bulletToDown(Clone)" || co.name == "bulletToRight(Clone)"){
        Destroy(co.gameObject);
};

        if (co.name == "bulletToUp(Clone)" || co.name == "bulletToLeft(Clone)" || co.name == "bulletToDown(Clone)" || co.name == "bulletToRight(Clone)"){
            transform.position =  spawnPoint.position;
            cur = 0;
};
}

IEnumerator ExecuteAfterTime(float time)
 {
     yield return new WaitForSeconds(time);

     // Code to execute after the delay
 }
}
