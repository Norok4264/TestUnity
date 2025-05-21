/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BamsongiGenerator : MonoBehaviour
{
    public GameObject bamsongiPrefab;
    public float throwForce = 10f;
    float power = 0f;
    float startVal = 0f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startVal = Input.mouseposition.y;
        }

        if (Input.GetMouseButtonUp(0))
        {
            power = Input.mousePosition.y - startVal;
        }
            GameObject bamsongi = Instantiate(bamsongiPrefab, transform.position,
                transform.rotation);

            // bamsongi.transform.position = new Vector3(transform.position.x, transform.position.y + 1,
            //     transform.position.z + 1);

            bamsongi.transform.position = transform.position + transform.forward; // 전방충돌코드

            //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //Vector3 worldDor = ray.direction;


            //bamsongi.GetComponent<BamsongiController>().Shoot(new Vector3(0, 200, 2000));
            //bamsongi.GetComponent<BamsongiController>().Shoot(worldDor * 2000);
            bamsongi.GetComponent<BamsongiController>().
                Shoot((transform.forward + transform.up  0.5).normalized * power * throwForce); ;
        }
}
}*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BamsongiGenerator : MonoBehaviour
{
    public GameObject bamsongiPrefab;
    public float throwForce = 10f;

    private float power = 0f;
    private float startVal = 0f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startVal = Input.mousePosition.y;  // 오타 수정 (mouseposition → mousePosition)
        }

        if (Input.GetMouseButtonUp(0))
        {
            power = Input.mousePosition.y - startVal;

            // 밤송이 생성
            GameObject bamsongi = Instantiate(bamsongiPrefab, transform.position + transform.forward, transform.rotation);

            // 발사 방향: 앞 + 위 (조절값 포함)
            Vector3 direction = (transform.forward + transform.up * 0.5f).normalized;

            // Shoot 함수 호출 (방향 * 힘)
            bamsongi.GetComponent<BamsongiController>().Shoot(direction * power * throwForce);
        }
    }
}
