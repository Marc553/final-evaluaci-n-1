 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //La velocidad que alcanzará 
    public float Speed = 5f;
    private float horizontalInput;
    private float verticalInput;
    private float turnSpeed = 22f;
    private float xyRange = 200;

    void Start()
    {
        transform.position = new Vector3(0, 100, 0);
    }

    void Update()
    {
        //Configura los inputs horizontales y verticales 
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // Rotación en eje  X e Y con Axis
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
        transform.Rotate(Vector3.left, turnSpeed * Time.deltaTime * verticalInput);

        //Da la orden para moverse en Z

        transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        
        //Limite de X
        if (transform.position.x > xyRange)
        {
            transform.position = new Vector3(xyRange, transform.position.y, transform.position.z);
        }   
        
        if (transform.position.x < -xyRange)
        {
            transform.position = new Vector3(-xyRange, transform.position.y, transform.position.z);
        } 
        
        //Limite de Y
        if (transform.position.y > xyRange)
        {
            transform.position = new Vector3(transform.position.x, xyRange , transform.position.z);
        }
        
        if (transform.position.y < 0)
        {
            transform.position = new Vector3(transform.position.x, 0 , transform.position.z);
        }
        
        //Limite de Z
        if (transform.position.z > xyRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, xyRange);
        }
        
        if (transform.position.z < -xyRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -xyRange);
        }


    }    
}
