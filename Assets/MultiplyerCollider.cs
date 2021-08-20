using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplyerCollider : MonoBehaviour
{
    [SerializeField] MultiplyerController multiplyerController;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="ball")
        {
            multiplyerController.BallCollided(other.gameObject);
        }
    }
}
