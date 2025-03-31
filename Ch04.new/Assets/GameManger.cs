using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject car;
    public GameObject flag;
    public GameObject distance;

    void Start()
    {
        car = GameObject.Find("car");
        flag = GameObject.Find("flag");
        distance = GameObject.Find("Distance"); // asset�� �ִ� ����ü �̸��� �����;� ��
    }


    void Update()
    {
        if (car == null) return;
        if (car == null) return;
        if (car == null) return;

        float length = flag.transform.position.x - car.transform.position.x;
        distance.GetComponent<TextMeshProUGUI>().text
            = "Distance : " + length.ToString("F2") + "m";

    }
}

