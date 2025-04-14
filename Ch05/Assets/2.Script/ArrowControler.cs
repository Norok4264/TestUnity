using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowControler : MonoBehaviour
{
    public float moveStep = 0.07f;
    public float r1 = 0.5f;
    public float r2 = 1.0f;
    //public GameObject gd;

    GameObject player;
    
    void Start()
    {
        Application.targetFrameRate = 60;
        player = GameObject.Find("player");
    }

    
    void Update()
    {
        transform.Translate(0, -moveStep, 0); 

        if (transform.position.y < -7f)
        {
            Destroy(gameObject); //자기 자신을 gameObject라고 함
        }

        //충돌 판정
        Vector2 p1 = transform.position;
        Vector2 p2 = player.transform.position;
        Vector2 dir = p1 - p2;
        float distance = dir.magnitude;


        if(distance < r1 + r2)
        {
            GameObject gd = GameObject.Find("Game Director");
            gd.GetComponent<GameDirector>().DecreaseHP();

            Destroy(gameObject);
        }
    }
}
