using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsManager : MonoBehaviour
{
    [SerializeField] GameObject ballPrefab;

    int currentScore;

    private void Start()
    {
        currentScore = 1;
    }

    public void AddBalls(GameObject collidedBall,int multiplayerVal)
    {
        DynamicBallController mainDynamicBallController = collidedBall.GetComponent<DynamicBallController>();

        int newScore = currentScore * multiplayerVal;
        int deltaScore = newScore - currentScore;
        for (int i = 0; i < deltaScore; i++)
        {

            GameObject go = Instantiate(ballPrefab, collidedBall.transform.position + new Vector3(Random.Range(-1.5f,1.5f), Random.Range(-1.5f, 1.5f), Random.Range(-1.5f, -0.5f)), Quaternion.identity,transform);

            DynamicBallController newBallDynamicBallController = go.GetComponent<DynamicBallController>();
            
            newBallDynamicBallController.rb.velocity = mainDynamicBallController.rb.velocity;
            newBallDynamicBallController.parentBallController = mainDynamicBallController;
          
        }




    }
}
