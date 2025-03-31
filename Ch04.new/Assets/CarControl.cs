using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControl : MonoBehaviour
{
    //public float speedRatio = 0.01f;
    //public float stopSpeed = 0.04f;
    //public float decreaseRate = 0.97f;


    float speed = 0;
    Vector2 startPos; //2차원이라 Vector2
    Vector2 endPos;
    AudioSource audio;

    void Start()
    {
        Application.targetFrameRate = 60; // 자동차 속도 설정 (값을 넣어보고 적절한 값 선택)
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
            Vector2 endPos = Input.mousePosition;
            float swipeLength = endPos.x - startPos.x;
            speed = swipeLength * speedRatio / 10000.0f;
            audio.Play();
        }

        transform.Translate(speed, 0, 0);
        //transform.position += new Vector3(speed, 0, 0);
        //transform.position *= Quaternion.Euler(0, 0, speed);
       
        speed *= decreaseRate;

        if(speed < stopSpeed)
        {
            speed = 0f;
        }
    }
}
