using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float Speed = 5f;

    void Update()
    {
        //Da la orden para moverse en Z

        transform.Translate(Vector3.forward * Speed * Time.deltaTime);
    }
}
