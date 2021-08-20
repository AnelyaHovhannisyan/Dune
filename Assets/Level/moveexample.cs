using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveexample : MonoBehaviour
{
    [SerializeField]
    private GameObject character;

    [SerializeField]
    private Rigidbody characterBody;
    //private float ScreenWidth;
    [SerializeField]
    private float fallSpeed;




    private void Awake()
    {
        GameManager.self.touchManager.OnTouchDown += OnTouchDown;
        GameManager.self.touchManager.OnTouchUp += OnTouchUp;
        GameManager.self.touchManager.OnTouchDrag += OnTouchDrag;
    }

    void OnTouchDown(Vector2 touch)
    {
        if (PullBallRoutineC != null) StopCoroutine(PullBallRoutineC);
        PullBallRoutineC = StartCoroutine(PullBallRoutine());
    }


    void OnTouchUp(Vector2 touch)
    {
        if (PullBallRoutineC != null) StopCoroutine(PullBallRoutineC);
    }


    void OnTouchDrag(Vector2 touch, Vector2 deltaTouch)
    {

    }


    Coroutine PullBallRoutineC;
    IEnumerator PullBallRoutine()
    {
        while(true)
        {
            characterBody.AddForce(Vector3.down * fallSpeed, ForceMode.Force);

            yield return new WaitForFixedUpdate();
        }
    }



    //void Start()
    //{
    //    ScreenWidth = Screen.width;
     
    //}

    
 

  
}
