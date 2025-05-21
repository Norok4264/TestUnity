using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class BamsongiGenerator : MonoBehaviour
{
    public GameObject bamsongiPrefab;
    float power = 0f;
    float startVal = 0f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startVal = Input.mouseposition.y;
        }

        if (input.
            //GameObject bamsongi = Instantiate(bamsongiPrefab, transform.position,
                //transform.rotation);

            // bamsongi.transform.position = new Vector3(transform.position.x, transform.position.y + 1,
            //     transform.position.z + 1);

            bamsongi.transform.position = transform.position + transform.forward; // 전방충돌코드

            //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //Vector3 worldDor = ray.direction;


            //bamsongi.GetComponent<BamsongiController>().Shoot(new Vector3(0, 200, 2000));
            //bamsongi.GetComponent<BamsongiController>().Shoot(worldDor * 2000);
            bamsongi.GetComponent<BamsongiController>().
                Shoot((transform.forward + transform.up  0.5).normalized * power); ;
        }
    }
}*/


public class BamsongiGenerator : MonoBehaviour
{
    public GameObject bamsongiPrefab;
    private float startVal;
    public float power = 2000f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startVal = Input.mousePosition.y;
        }

        if (Input.GetMouseButtonUp(0))
        {
            // 밤송이 생성
            GameObject bamsongi = Instantiate(bamsongiPrefab, transform.position + transform.forward, transform.rotation);

            // 방향 계산: 전방 + 위 방향
            Vector3 shootDir = (transform.forward + transform.up).normalized;

            // 발사
            bamsongi.GetComponent<BamsongiController>().Shoot(shootDir * power);
        }
    }
}
