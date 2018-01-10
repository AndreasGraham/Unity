using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointGate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

    void OnCollisionEnter(Collision other)
    {
        var playerController = other.collider.GetComponent<BallController>();
        if(other.collider.tag == "Player" && playerController.score > 5)
        {
            Destroy(gameObject);
        }
    }
}
