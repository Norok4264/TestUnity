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
                      // Vector2 endPos;

    void Start()
    {
        Application.targetFrameRate = 60; // 자동차 속도 설정 (값을 넣어보고 적절한 값 선택)
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
            speed = swipeLength / 500.0f;
        }

        transform.Translate(speed, 0, 0);
        //transform.position += new Vector3(speed, 0, 0);
        //transform.position *= Quaternion.Euler(0, 0, speed);
        speed *= 0.98f;

        //if(speed < stopSpeed)
        //{
        //    speed = 0f;
        //}
    }
}
