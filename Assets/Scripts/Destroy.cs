using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    private float xRange = 200f;
    private float yRange = 200f;
    private float zRange = 200f;
    

    void Update()
    {
        //Bala fallida
        //eje x
        if(transform.position.x > xRange || transform.position.x < -xRange)
        {
            Destroy(gameObject);
        }
        
        //eje y
        if(transform.position.x > yRange || transform.position.x < 0)
        {
            Destroy(gameObject);
        }
        
        //eje z
        if(transform.position.x > zRange || transform.position.x < -zRange)
        {
            Destroy(gameObject);
        }

    }
}
