using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerController : MonoBehaviour {
    public Text timer;
    private float Tiempo = 150f;
	// Use this for initialization
	void Start () {
        timer.text = " " + Tiempo;
	}
	
	// Update is called once per frame
	void Update () {
        Tiempo -= Time.deltaTime;
        timer.text = " " + Tiempo.ToString("f0");

        if (Tiempo <= 0)
        {
            SceneManager.LoadScene("Muerte");
        }

    }
}
