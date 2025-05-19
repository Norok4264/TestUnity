using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetPositionController : MonoBehaviour
{
    private void OnDrawsGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position, 1f);
    }
}
