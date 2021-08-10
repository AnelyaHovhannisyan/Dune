using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    [SerializeField]
    private Transform target;
    [SerializeField]
    [Range(0.01f, 1f)]

    private float speed = 0.125f;
    [SerializeField]
    private Vector3 offset;
    private Vector3 velocity = Vector3.zero;
    private void FixedUpdate()
    {

        Vector3 d_position = target.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, d_position, ref velocity, speed);
    }



}
