using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverCamara : MonoBehaviour {
    public GameObject seguir;
    public Vector2 mincamPos, maxcamPos;
    public float smoothTime;

    public Vector2 velocidad;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    private void FixedUpdate()
    {
      
        float posx = Mathf.SmoothDamp(transform.position.x, seguir.transform.position.x, ref velocidad.x, smoothTime);
        float posy = Mathf.SmoothDamp(transform.position.y, seguir.transform.position.y, ref velocidad.y, smoothTime);

        transform.position = new Vector3(Mathf.Clamp(posx, mincamPos.x, maxcamPos.x), Mathf.Clamp(posy, mincamPos.y, maxcamPos.y), transform.position.z);
    

    }
}
