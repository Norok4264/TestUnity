using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCloud : MonoBehaviour
{
float moveSpeed = 0.05f;
float maxWidth = 7f;

    int direction = 1;

    void Update()
    {
        if(transform.position.x > maxWidth)
        {
            direction = -1;
        }
        if(transform.position.x < -maxWidth)
        {
            direction = 1;
        }

        transform.Translate(moveSpeed*direction, 0, 0);
    }
}
