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
        if (transform.position.y < -5f) // 경기장 밖으로 공 떨어지면 위치 리셋
        {
            ResetBall();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BlueGoal")) // 블루 득점
        {
            blueScore++;
            blueScoreText.text = blueScore.ToString();  
            ResetBall();
        }
        else if (other.CompareTag("RedGoal")) // 레드 득점
        {
            redScore++;
            redScoreText.text = redScore.ToString();    
            ResetBall();
        }
    }

    void ResetBall()
    {
        rb.velocity = Vector3.zero; // 속도 초기화
        rb.angularVelocity = Vector3.zero; // 회전 초기화
        transform.SetPositionAndRotation(initialPosition.position, initialPosition.rotation); // 초기위치로
    }
}