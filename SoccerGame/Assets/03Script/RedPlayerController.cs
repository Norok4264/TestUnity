using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        float moveX = 0f;
        float moveZ = 0f;

        if (Input.GetKey(KeyCode.LeftArrow)) moveX = -1;
        if (Input.GetKey(KeyCode.RightArrow)) moveX = 1;
        if (Input.GetKey(KeyCode.UpArrow)) moveZ = 1;
        if (Input.GetKey(KeyCode.DownArrow)) moveZ = -1;

        Vector3 moveDirection = new Vector3(moveX, 0f, moveZ).normalized; // normalized -> 방향은 유지하되 크기를 통일해서 이동 속도가 방향에 따라 달라지지 않도록
        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }
}
