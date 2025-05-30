using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GoalEvent : MonoBehaviour
{
    public TextMeshProUGUI blueScoreText;
    public TextMeshProUGUI redScoreText;
    public Transform initialPosition;

    private int blueScore = 0;
    private int redScore = 0;
    private Rigidbody rb;

    public int GetBlueScore()
    {
        return blueScore;
    }

    public int GetRedScore()
    {
        return redScore;
    }

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (transform.position.y < -5f)
        {
            ResetBall();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BlueGoal"))
        {
            blueScore++;
            blueScoreText.text = blueScore.ToString();  // 숫자만 출력
            ResetBall();
        }
        else if (other.CompareTag("RedGoal"))
        {
            redScore++;
            redScoreText.text = redScore.ToString();    // 숫자만 출력
            ResetBall();
        }
    }

    void ResetBall()
    {
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        transform.SetPositionAndRotation(initialPosition.position, initialPosition.rotation);
    }
}