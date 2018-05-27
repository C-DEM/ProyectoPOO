using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveJefe : MonoBehaviour
{
    public float maxSpeed = 1f;
    public float speed = 1f;
    private Rigidbody2D rb2d;
    public int vidas = 4;
    private SpriteRenderer spr1;
   
   
    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb2d.AddForce(Vector2.right * speed);
        float speedlimite = Mathf.Clamp(rb2d.velocity.x, -maxSpeed, maxSpeed);
        rb2d.velocity = new Vector2(speedlimite, rb2d.velocity.y);

        if (rb2d.velocity.x > -0.01f && rb2d.velocity.x < 0.01f)
        {
            speed = -speed;
            rb2d.velocity = new Vector2(speed, rb2d.velocity.y);
        }
        if (speed > 0)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        else if (speed < 0)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            float YOffset = 0.2f;
            if ((transform.position.y + YOffset) < col.transform.position.y)
            {
                col.SendMessage("EnemyJump");
                if (vidas == 0)
                {
                    Destroy(gameObject);
                }
                else
                {
                    vidas = vidas - 1;
                    int rnd = Random.Range(314,329);
                    transform.position = new Vector3(rnd, 1, 0);
                    //Color color = new Color(124 / 255f, 48 / 255f, 48 / 255f, 255 / 255f);
                    GetComponent<SpriteRenderer>().color= new Color(Random.value,Random.value,Random.value,Random.value);
                    //spr1.color = color;
                    
                }
              
            }
            else
            {
                col.SendMessage("EnemyGolpe", transform.position.x);
            }

        }
    }
    void Activarmovimiento()
    {
       
        spr1.color = Color.white;
    }

}
