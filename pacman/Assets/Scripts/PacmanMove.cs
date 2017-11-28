using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PacmanMove : MonoBehaviour {
    public float speed = 0.4f;
    Vector2 dest = Vector2.zero;
    public GameObject BulletToRight, BulletToLeft, BulletToUp, BulletToDown;
    Vector2 bulletPos;
    public float fireRate = 0.5f;
    float nextFire = 0.0f;
    int facing = 0;

    void Start() {
        dest = transform.position;
    }

    void Update() {
      if (Input.GetKey(KeyCode.Space) && Time.time > nextFire) {
    nextFire = Time.time + fireRate;
    fire();
      }
    }

void FixedUpdate() {
    // Move closer to Destination
    Vector2 p = Vector2.MoveTowards(transform.position, dest, speed);
    GetComponent<Rigidbody2D>().MovePosition(p);

    // Check for Input if not moving
    if ((Vector2)transform.position == dest) {
        if (Input.GetKey(KeyCode.UpArrow) && valid(Vector2.up)){
            dest = (Vector2)transform.position + Vector2.up;
            facing = 3;
          }
        if (Input.GetKey(KeyCode.RightArrow) && valid(Vector2.right)){
            dest = (Vector2)transform.position + Vector2.right;
            facing = 1;
          }
        if (Input.GetKey(KeyCode.DownArrow) && valid(-Vector2.up)){
            dest = (Vector2)transform.position - Vector2.up;
            facing = 4;
          }
        if (Input.GetKey(KeyCode.LeftArrow) && valid(-Vector2.right)){
            dest = (Vector2)transform.position - Vector2.right;
            facing = 2;
          }
    }
// Animation Parameters
    Vector2 dir = dest - (Vector2)transform.position;
    GetComponent<Animator>().SetFloat("DirX", dir.x);
    GetComponent<Animator>().SetFloat("DirY", dir.y);
}

    bool valid(Vector2 dir) {
        // Cast Line from 'next to Pac-Man' to 'Pac-Man'
        Vector2 pos = transform.position;
        RaycastHit2D hit = Physics2D.Linecast(pos + dir, pos);
        return (hit.collider == GetComponent<Collider2D>());
    }

    void fire() {
      bulletPos = transform.position;
      if (facing == 1) {
        // right
        bulletPos += new Vector2 (+1f, 0f);
        Instantiate (BulletToRight, bulletPos, Quaternion.identity);
      } else if (facing == 2) {
        // left
          bulletPos += new Vector2 (-1f, 0f);
          Instantiate (BulletToLeft, bulletPos, Quaternion.identity);
        } else if (facing == 3) {
          // up
          bulletPos += new Vector2 (0f, +1f);
          Instantiate (BulletToUp, bulletPos, Quaternion.identity);
        } else if (facing == 4) {
          // down
          bulletPos += new Vector2 (0f, -1f);
          Instantiate (BulletToDown, bulletPos, Quaternion.identity);
        }
      }
    }
