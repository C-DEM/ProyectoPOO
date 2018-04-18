﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class move : MonoBehaviour
{
	public float maxSpeed = 5f;
	public float speed = 2f;
    public float jumpPower = 6.5f;
	public bool grounded;
	private Rigidbody2D rb2d;
    private Animator anim;
    private bool jump;
    private bool doblejump;
    // Use this for initialization
    void Start () 
	{
		rb2d = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		anim.SetFloat("Speed",Mathf.Abs(rb2d.velocity.x));
		anim.SetBool ("Grounded", grounded);

        if (grounded)
        {
            doblejump = true;

        }

        if ((Input.GetKeyDown(KeyCode.UpArrow)|| Input.GetKeyDown(KeyCode.W)))
        {
            if(grounded)
            {
                jump = true;
                doblejump = true;
            }
            else if (doblejump)
            {
                jump = true;
                doblejump = false;
            }
        }
		
	}
	void FixedUpdate()
	{
        Vector3 fixedVelocity = rb2d.velocity;
        fixedVelocity.x *= .75f;
        if (grounded)
        {
            rb2d.velocity = fixedVelocity;
        }
    
		float h = Input.GetAxis("Horizontal");

		rb2d.AddForce(Vector2.right * speed * h);

		float speedlimite = Mathf.Clamp (rb2d.velocity.x, -maxSpeed, maxSpeed);
		rb2d.velocity = new Vector2(speedlimite, rb2d.velocity.y);

        if (h>0f)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        if (h < 0f)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
       if (jump)
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, 0);
            rb2d.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
            jump = false;
        }

        Debug.Log(rb2d.velocity.x);
        


	}
     void OnBecameInvisible()
     {

        transform.position = new Vector3(-7, 0, 0);
     }
}