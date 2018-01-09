using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hazard : MonoBehaviour {

   public int damage;
	// Use this for initialization
	void Start () {
        damage = 2;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision other)
    {
        if(other.collider.tag == "Player")
        {
            var playerController = other.collider.GetComponent<BallController>();
            if(playerController != null)
            {
                playerController.health -= damage;
                Destroy(gameObject);
            }
        }
    }
}
