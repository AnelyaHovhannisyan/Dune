using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{


    private Rigidbody rb;

    [SerializeField]
    private float speed = 10.0f;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {

        float sideForce = Input.GetAxis("Horizontal") * speed;
       
        rb.AddForce(0f, 0f, sideForce);
        
    }

    private void FixedUpdate()
    {

    }
}

