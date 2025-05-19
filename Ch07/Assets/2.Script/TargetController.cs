using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour
{
    Transform playerTR;

    void Start()
    {
        playerTR = GameObject.Find("Player").transform;
    }

    
    void Update()
    {
        transform.LookAt(playerTR);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        Destroy(collision.gameObject);
    }
}
