using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    //public float Speed = 5f;
    public float z = 1000f;
 

    void Update()
    {
        //Da la orden para rotar tod el rato
        transform.Rotate(new Vector3(0f, 0f, z));
    }
}
