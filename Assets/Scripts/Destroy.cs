using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    private float Range = 300f;
   
  
    void Update()
    {
        //Bala fallida
        //eje x
        if(transform.position.x > Range || transform.position.x < -Range)
        {
            Destroy(gameObject);
        }
        
        //eje y
        if(transform.position.y > Range || transform.position.y < 0)
        {
            Destroy(gameObject);
        }

        //eje z
        if (transform.position.z > Range || transform.position.z < -Range)
        {
            Destroy(gameObject);
        }

    }
}
