using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTF : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotationSpeed = 15f;

    void Update()
    {
        float xInput = Input.GetAxis("Horizontal"); //유니티의 내장갑 이용
        float zInput = Input.GetAxis("Vertical");

        float move = zInput * moveSpeed * Time.deltaTime; //업데이트함수가 호출될때 시간차이를 상쇄시켜줌 (프레임간의 간격을 의미)
        float rotate = xInput * rotationSpeed * Time.deltaTime;
        transform.Translate(0, 0, move); //오브젝트가 바라보고 있는방향(z축)으로 이동 (유니티에서는 평면이 x, z축임 위로 가는게 y축)
        transform.Rotate(0, rotate, 0); //y축을 기준으로 회전하니까
    }
}
