using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControl : MonoBehaviour
{
    public float speedRatio = 0.0000001f; // �ӵ� ����
    public float stopSpeed = 0.02f; // ���ߴ� ���� �ӵ� ����
    public float decreaseRate = 0.095f; // ���ӷ� ���� (�� �ε巴�� ����)

    private float speed = 0;
    private Vector2 startPos;
    private Vector2 endPos;
    private AudioSource audio;

    void Start()
    {
        Application.targetFrameRate = 60;
        audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            endPos = Input.mousePosition;
            float swipeLength = endPos.x - startPos.x;
            speed = swipeLength * speedRatio;

            if (Mathf.Abs(speed) > stopSpeed)
            {
                audio.Play();
            }
        }

        transform.Translate(speed, 0, 0);
        speed *= decreaseRate;

        if (Mathf.Abs(speed) < stopSpeed)
        {
            speed = 0f;
        }
    }
}

