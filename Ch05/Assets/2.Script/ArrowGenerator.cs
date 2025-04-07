using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerater : MonoBehaviour
{
    public GameObject arrowPrefab;
    public float span = 1.0f; //생성 주기 public으로 outlet 설정
    float delta = 0f;

    void Update()
    {
        delta += Time.deltaTime;
        if (delta > span)
        {
            GameObject go = Instantiate(arrowPrefab);
            int px = Random.Range(-8, 9); //6은 나와도 7은 못나옴 -6 ~ 6
            go.transform.position = new Vector3(px, 6, 0);

            delta = 0;
        }
    }
}
