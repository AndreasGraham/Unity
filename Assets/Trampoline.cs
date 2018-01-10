using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour {


    // Use this for initialization
    public float bounceFactor;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            other.GetComponent<Rigidbody>().AddForce(0,bounceFactor,0,ForceMode.Impulse);
        }
       
    }
}
