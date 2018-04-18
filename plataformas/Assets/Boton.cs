using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boton : MonoBehaviour {
    public void otravez()
    {
        SceneManager.LoadScene("Scenes");
    }
    public void YaNo()
    {
        SceneManager.LoadScene("Empezar");
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
