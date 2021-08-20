using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    [SerializeField] Transform firstBall;

    private void Start()
    {
        StartCamera();
    }


    void StartCamera()
    {
        if (UpdateCameraPosC != null) StopCoroutine(UpdateCameraPosC);

        UpdateCameraPosC = StartCoroutine(UpdateCameraPos());
    }

    Coroutine UpdateCameraPosC;
    IEnumerator UpdateCameraPos()
    {
        while(true)
        {
            transform.position = firstBall.position;

            yield return new WaitForFixedUpdate();
        }

    }
}
