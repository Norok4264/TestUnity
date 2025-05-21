using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit; 
            if (Physics.Raycast(ray, out hit, Mathf.Infinity)) 
            {
                float x = Mathf.RoundToInt(hit.point.x); //반올림 해서 정수로
                float z = Mathf.RoundToInt(hit.point.z);
                transform.position = new Vector3(x, transform.position.y, z);

            }
        }
    }
}
