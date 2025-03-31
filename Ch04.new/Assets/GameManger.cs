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
        distance = GameObject.Find("distance"); // asset에 있는 구조체 이름을 가져와야 됨
    }


    void Update()
    {
        if (car == null) return;
        if (flag == null) return;
        if (distance == null) return;

        float length = flag.transform.position.x - car.transform.position.x;
        distance.GetComponent<TextMeshProUGUI>().text
            = "거리 : " + length.ToString("F2") + "m";

    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

