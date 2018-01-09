using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

    Rigidbody rb;
    public float speed;
    float normspeed = 500;
    float boost = 1000;
    public float sprintTime = 2;
    public int score;
    public int health;
    public float maxSprint;
	// Use this for initialization
	void Start () {
        health = 10;
        score = 0;
        rb = GetComponent<Rigidbody>(); // looks for component on the object, so we are assining rb to the component on the object. this allows us to make the variable private
	}
	
	// Update is called once per frame
	void Update () {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(horizontal, 0, vertical);
        if (Input.GetKey("space") && sprintTime > 0)
        {
            speed = boost;
            sprintTime -= Time.deltaTime;
        }
       else if(!Input.GetKey("space") &&  sprintTime <= maxSprint)
        {
            sprintTime += Time.deltaTime;
            speed = normspeed;
        }
        else
        {
            speed = normspeed;
        }
        rb.AddForce(move*speed*Time.deltaTime); // time.delta time smooths it out based on frams
        if(health <= 0)
        {
            Destroy(gameObject);
        }
	}
}
