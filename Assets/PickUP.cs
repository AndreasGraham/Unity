using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUP : MonoBehaviour {

	// Use this for initialization
    public int scoreAdded;
    public float rotationSpeed;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(rotationSpeed, 0, rotationSpeed / 3);
	}

    void OnCollisionEnter(Collision other) // collision ohter is other collider hit, ie player
    {
        if(other.collider.tag == "Player")
        {
            var playerController = other.collider.GetComponent <BallController>(); // gets ball controller script so we can get score var takes what ever type it recieves, auto fills
            if(playerController.tag != null) // checks to makes sure 
            {
                playerController.score += scoreAdded; 
                Destroy(gameObject);
            }
        }
    }
}
