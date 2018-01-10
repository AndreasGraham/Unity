using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineNumbers : MonoBehaviour {

	IEnumerator Coroutinecounting()
    {
        int number = 0;
        while (number < 11) 
        {
            Debug.Log(number);
            number++;
            yield return null;
   
        }
    }

    void Start()
    {
        StartCoroutine(Coroutinecounting());
    }
}
