using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicBallController : MonoBehaviour
{

    public DynamicBallController parentBallController;

    [SerializeField]
    private float fallSpeed;

    public Rigidbody rb;

    private void Start()
    {
        GameManager.self.touchManager.OnTouchDown += OnTouchDown;
        GameManager.self.touchManager.OnTouchUp += OnTouchUp;
        GameManager.self.touchManager.OnTouchDrag += OnTouchDrag;


        if(parentBallController!=null) FollowParent();
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
        while (true)
        {
            rb.AddForce(Vector3.down * fallSpeed * Time.fixedDeltaTime, ForceMode.VelocityChange);

            yield return new WaitForFixedUpdate();
        }
    }

    [SerializeField] float minParentDistance;
    [SerializeField] float parentFollowForce;
    [SerializeField] float followDelay;

    void FollowParent()
    {
        if (FollowParentRoutineC != null) StopCoroutine(FollowParentRoutineC);

        FollowParentRoutineC = StartCoroutine(FollowParentRoutine());
    }

    Coroutine FollowParentRoutineC;
    IEnumerator FollowParentRoutine()
    {
        Vector3 diff;

        while (true)
        {

            rb.transform.position = Vector3.Lerp(rb.transform.position, parentBallController.rb.transform.position, Time.fixedDeltaTime * followDelay);

            //diff = parentBallController.rb.transform.position - rb.transform.position;

            //if (diff.magnitude > minParentDistance)
            //{
            //    rb.AddForce(diff * parentFollowForce, ForceMode.VelocityChange);
            //}

            yield return new WaitForFixedUpdate();
        }
    }
}
