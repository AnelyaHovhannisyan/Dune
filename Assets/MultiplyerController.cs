using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MultiplyerController : MonoBehaviour
{
    [SerializeField] int multiplyerValue;
    [SerializeField] GameObject collider;

    [SerializeField] TMPro.TextMeshPro text;

    void Start()
    {
        UpdateText();
    }

    void UpdateText()
    {
        text.text = "x" + multiplyerValue;
    }

    public void BallCollided(GameObject ball)
    {
        GameManager.self.ballsManager.AddBalls(ball,multiplyerValue);

        collider.SetActive(false);
    }

}
