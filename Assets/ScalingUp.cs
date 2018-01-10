using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScalingUp : MonoBehaviour {

    public float scaleTime;
    Vector3 scaleSize;
    public float scale;
    Vector3 startScale;
    void Start()
    {
        scaleSize = new Vector3(scale, scale, scale);
        startScale = transform.localScale;
        //StartCoroutine(CoroutineScaling());
    }
	
    IEnumerator CoroutineScaling()
    {
        //while(transform.localScale.x < scaleSize.x && transform.localScale.y < scaleSize.y && transform.localScale.z < scaleSize.z)
        //{
        //    transform.localScale += new Vector3(0.2f, 0.2f, 0.2f);
        //}
       
        while(transform.localScale != scaleSize)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, scaleSize, scaleTime * Time.deltaTime);
            yield return new WaitForSeconds(scaleTime);
        }
    }

    void Update()
    {
        if(transform.localScale != scaleSize)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, scaleSize, scaleTime * Time.deltaTime);
        }
        else
        {
            transform.localScale = Vector3.Lerp(transform.localScale, startScale, scaleTime * Time.deltaTime);
        }
    }

	// need the difference between the desired scale and the current scale
    // need to incrementally scale up from current scale to desired scale over the set period of time
    // divide difference in scale by the amount of aloted time to incrementally reach desired size
   

}
