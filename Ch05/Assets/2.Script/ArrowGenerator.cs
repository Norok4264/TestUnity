using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerater : MonoBehaviour
{
    public GameObject arrowPrefab;
    public float span = 1.0f; //���� �ֱ� public���� outlet ����
    float delta = 0f;

    void Update()
    {
        delta += Time.deltaTime;
        if (delta > span)
        {
            GameObject go = Instantiate(arrowPrefab);
            int px = Random.Range(-8, 9); //6�� ���͵� 7�� ������ -6 ~ 6
            go.transform.position = new Vector3(px, 6, 0);

            delta = 0;
        }
    }
}
