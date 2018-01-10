using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannon : MonoBehaviour
{
    Rigidbody rb;
    public GameObject shootPosition;
    public GameObject projectile;
    public float force;
    public float radius;
    public bool editorTest;
    // Use this for initialization
    void Start()
    {
        spawn();
    }

    // Update is called once per frame
    void Update()
    {
        float myTime = 10;
        if(editorTest == true)
        {
            if((myTime - Time.deltaTime) > 0)
            {
                spawn();
            }
            
            editorTest = false;
        }
    }

   

    void spawn()
    {
        GameObject spawnedProjectile = Instantiate(projectile);
        spawnedProjectile.transform.position = shootPosition.transform.position;
        rb = spawnedProjectile.GetComponent<Rigidbody>();
        spawnedProjectile.transform.rotation = shootPosition.transform.rotation;
        rb.AddExplosionForce(force, shootPosition.transform.position - shootPosition.transform.forward, radius, 0, ForceMode.Impulse);

        
    }
}
