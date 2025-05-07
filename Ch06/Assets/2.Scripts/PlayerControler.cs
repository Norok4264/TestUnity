using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControler : MonoBehaviour
{
    Rigidbody2D rigid2D;
    Animator animator;
    public float jumpForce = 60.0f;
    public float walkForce = 100.0f;
    float maxWalkSpeed = 2.0f;

    void Start()
    {
        Application.targetFrameRate = 60;
        rigid2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) & rigid2D.velocity.y == 0) //점프 한번만
        {
            animator.SetTrigger("JumpTrigger"); //int면 SetInt로 함
            rigid2D.AddForce(transform.up * jumpForce);
            //rigid2D.AddForce(new Vector2(0,1) * jumpForce);            
        }

        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow)) key = 1;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;

        float speedX = Mathf.Abs(rigid2D.velocity.x);

        if (speedX < maxWalkSpeed)
        {
            rigid2D.AddForce(transform.right * key * walkForce);
        }

        if(key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }

        if(rigid2D.velocity.y == 0)
        {
            animator.speed = speedX / 2.0f;
        }
        else
        {
            animator.speed = 1.0f;
        }

        //animator.speed = speedX / 2.0f;

        if (transform.position.y < -10) //떨어지면 죽음
        {
            SceneManager.LoadScene("GameSceneMove");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("Goal");
        SceneManager.LoadScene("ClearScene");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag != "Cloud") return; //Cloud tag 없으면 작동 X

        transform.SetParent(collision.gameObject.transform); //바닥과 충돌하면 바닥의 자식이 되기 때문에 영향을 받아 스케일이 커짐 -> tag써야함 
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "Cloud") return; 

        transform.SetParent(null);
    }
}
