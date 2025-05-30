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

        Vector3 moveDirection = new Vector3(moveX, 0f, moveZ).normalized;
        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }
}
