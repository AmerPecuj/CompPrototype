using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Pacdot : MonoBehaviour {

    public Text countText;
    public Text winText;
    private int count;

    void Start ()
    {
        count = 0;
        SetCountText ();
        winText.text = "";
    }

    void OnTriggerEnter2D(Collider2D co) {
        if (co.name == "pacman")
	{
	    count = count + 1;
            SetCountText ();
            gameObject.SetActive (false);
	}
    }

    void SetCountText ()
    {
        countText.text = "Count: " + count.ToString ();
        if (count >= 12)
        {
            winText.text = "You Win!";
        }
    }
}