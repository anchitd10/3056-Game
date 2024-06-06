using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody rb;
    [SerializeField] float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        //Vector3 forwardMove = transform.forward * speed * Time.deltaTime;
        //rb.MovePosition(rb.position + forwardMove);


        //Vector3 downwardMove = transform.down * speed * Time.deltaTime;
        Vector3 downwardMove = Vector3.down * speed * Time.deltaTime;
        rb.MovePosition(rb.position + downwardMove);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player collided");
        }
    }
}
