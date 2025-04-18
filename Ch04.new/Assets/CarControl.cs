using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControl : MonoBehaviour
{
    public float speedRatio = 0.0000001f; // �ӵ� ����
    public float stopSpeed = 0.02f; // ���ߴ� ���� �ӵ� ����
    public float decreaseRate = 0.095f; // ���ӷ� ���� (�� �ε巴�� ����)

    float speed = 0;
    Vector2 startPos;
    Vector2 endPos;
    AudioSource audio;

    bool gameEnded = false;
    bool carStarted = false;

    void Start()
    {
        Application.targetFrameRate = 60;
        audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (gameEnded) return;
        if (Input.GetMouseButtonDown(0))
        {
            startPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            endPos = Input.mousePosition;
            float swipeLength = endPos.x - startPos.x;
            speed = swipeLength * speedRatio;
            audio.Play();
            carStarted = true;
        }

        transform.Translate(speed, 0, 0);
        speed *= decreaseRate;

        if (carStarted && speed < stopSpeed)
        {
            speed = 0f;
            gameEnded = true;
        }
    }
}

