using UnityEngine;
using System.Collections;

public class PacmanMove : MonoBehaviour {
    public float speed = 0.4f;
    Vector2 dest = Vector2.zero;
    public GameObject =  BulletToRight, BulletToLeft;
    Vector2 bulletPos;
    public float fireRate = 0.5f;
    float nextFire = 0.0f;

    void Start() {
        dest = transform.position;
    }

    void Update() {
      if (Input.GetButtonDown ("Fire1") && Time.time > nextFire) {
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
        if (Input.GetKey(KeyCode.UpArrow) && valid(Vector2.up))
            dest = (Vector2)transform.position + Vector2.up;
        if (Input.GetKey(KeyCode.RightArrow) && valid(Vector2.right))
            dest = (Vector2)transform.position + Vector2.right;
        if (Input.GetKey(KeyCode.DownArrow) && valid(-Vector2.up))
            dest = (Vector2)transform.position - Vector2.up;
        if (Input.GetKey(KeyCode.LeftArrow) && valid(-Vector2.right))
            dest = (Vector2)transform.position - Vector2.right;
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
      if (facingRight) {
        bulletPos += new Vector2 (-1f, -0.43f);
        Instantiate (BulletToRight, bulletPos, Quaternion.identify);
        } else {
          bulletPos += new Vector2 (-1f, -0.43f);
          Instantiate (BulletToLeft, bulletPos, Quaternion.identify);
        }
      }
    }
}
