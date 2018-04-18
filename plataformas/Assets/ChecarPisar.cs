using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChecarPisar : MonoBehaviour {

	private move player;
    private Rigidbody2D rb2d;
	// Use this for initialization
	void Start () {
		player = GetComponentInParent<move>();

	}

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Plataforma")
        {
            rb2d.velocity = new Vector3(0f, 0f, 0f);
            player.transform.parent = col.transform;
            player.grounded = true;
        }

    }

    void OnCollisionStay2D (Collision2D col)
	{
        if (col.gameObject.tag == "Plataforma")
        {
            player.transform.parent = col.transform;
            player.grounded = true;
        }
        if(col.gameObject.tag == "Ground") 
        {
            player.grounded = true;
        }
        rb2d = GetComponentInParent<Rigidbody2D>();
    }


    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.tag == "Plataforma")
        {
            player.transform.parent = null;
            player.grounded = false;

        }
        if (col.gameObject.tag == "Ground")
        {
            player.grounded = false;

        }
    }


    }
