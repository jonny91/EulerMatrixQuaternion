using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmozHelper : MonoBehaviour
{
    public float Length = 3;

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        var direction = Vector3.right * Length;
        Gizmos.DrawRay(transform.position, direction);

        Gizmos.color = Color.green;
        direction = Vector3.up * Length;
        Gizmos.DrawRay(transform.position, direction);

        Gizmos.color = Color.blue;
        direction = Vector3.forward * Length;
        Gizmos.DrawRay(transform.position, direction);
    }
}