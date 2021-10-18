using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grow : MonoBehaviour
{
    
    private void Start()
    {
        // var scale = pizza.transform.localScale.x;
        // pizza.transform.localScale = new Vector3(scale);
    }

    void FixedUpdate()
    {
        var secondsToGrow = 1;
        var lScale = transform.localScale.x;
        if ( lScale > 0.5f)
        {
            Destroy(gameObject);
            return;
        }

        float sizeIncr = 1f / (secondsToGrow) * Time.deltaTime;
       // size += sizeIncr;


        //float scaleIncr = (1f - startSize) / (secondsToGrow) * Time.deltaTime;
        transform.localScale = new Vector3(lScale + 0.01f,
            lScale + 0.01f,
            lScale);
        
    }
}
