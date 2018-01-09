﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public GameObject player;
    Vector3 offset;

	// Use this for initialization
	void Start () {
        offset = transform.position - player.transform.position; // every monobehavior has a transform
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = player.transform.position + offset;
	}
}