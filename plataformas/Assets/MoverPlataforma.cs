using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverPlataforma : MonoBehaviour {

    public Transform objeivo;
    public float speed;
    private Vector3 start, end;
	// Use this for initialization
	void Start ()
    {
        if (objeivo!=null)
        {
            objeivo.parent = null;
            start = transform.position;
            end = objeivo.position;
        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void FixedUpdate()
    {
        if (objeivo != null)
        {
            float fixedSpeed = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, objeivo.position, fixedSpeed);
        }
        if (transform.position == objeivo.position)
        {
            objeivo.position = (objeivo.position == start) ? end : start;
        }
    }
}
