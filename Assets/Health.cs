using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    public int health;
    // Use this for initialization
    void Start()
    {
        health = 1;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Player")
        {
            var playerController = other.collider.GetComponent<BallController>();
            if (playerController.tag != null)
            {
                if(playerController.health < 10)
                {
                    playerController.health += health;
                }
               
                Destroy(gameObject);
            }
        }
    }
}