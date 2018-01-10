using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour {

	void OnTriggerEnter(Collider other)
    {
        Debug.Log("A");
        BallController player = other.GetComponent<BallController>();
        if(player != null)
        {
            Debug.Log("B");
            player.checkpointLocation = transform.position;
        }
    }
}
