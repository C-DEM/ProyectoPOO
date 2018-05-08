using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaerPlataforma : MonoBehaviour {
    public float retrasocaida = 1f;
    public float retrasoreaparecer = 5f;

    private Rigidbody2D rb2d;
    private PolygonCollider2D pc2d;
    private Vector3 start;
	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        pc2d = GetComponent<PolygonCollider2D>();
        start = transform.position;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            Invoke("Caer", retrasocaida);
            Invoke("Reaparecer", retrasocaida+retrasoreaparecer);

        }
    }
    void Caer()
    {
        rb2d.isKinematic = false;
        pc2d.isTrigger = true;
    }
    void Reaparecer()
    {
        transform.position = start;
        rb2d.isKinematic = true;
        rb2d.velocity = Vector3.zero;
        pc2d.isTrigger = false;

    }
}
