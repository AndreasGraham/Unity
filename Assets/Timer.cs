using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Timer : MonoBehaviour {

    // Use this for initialization
    public float myTime = 10.0f;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        myTime -= Time.deltaTime;
        if(myTime <= 0.0)
        {
            SceneManager.LoadScene("RolleABall_00");
        }
	}
}
