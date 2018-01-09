using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUPSpawner : MonoBehaviour {

    // Use this for initialization
    public GameObject pickup;
    public float spawnInterval;
    public float range;
    float spawnTimer;
	void Start () {
        spawnTimer = 0;
	}
	
    void spawnPickup()
    {
        GameObject spawnedPickup = Instantiate(pickup); // references object just spawned
        float randomX = Random.Range(-range, range);
        float randomZ = Random.Range(-range, range);
        spawnedPickup.transform.position = transform.position + new Vector3(randomX, 0, randomZ);
        spawnedPickup.GetComponent<PickUP>().scoreAdded = Random.Range(0, 5);
    }

	// Update is called once per frame
	void Update () {
        spawnTimer -= Time.deltaTime;
        if(spawnTimer <= 0)
        {
            spawnTimer = spawnInterval;
            spawnPickup();
           
        }
		
	}
}
