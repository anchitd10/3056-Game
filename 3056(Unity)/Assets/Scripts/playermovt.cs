using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovt : MonoBehaviour
{
    [SerializeField] float Movtspeed;

    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Movtspeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Movtspeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Movtspeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Movtspeed * Time.deltaTime);
        }
    }
}
