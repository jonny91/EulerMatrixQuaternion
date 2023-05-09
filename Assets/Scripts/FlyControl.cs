/*************************************************************************************
 *
 * 文 件 名:   FlyControl.cs
 * 描    述: 
 * 
 * 创 建 者：  洪金敏 
 * 创建时间：  2023-05-5 02:21:52
*************************************************************************************/

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyControl : MonoBehaviour
{
    public float Thrust;
    public float ThrustMultiplier;
    public float YawMultiplier;
    public float PitchMultiplier;

    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float pitch = Input.GetAxis("Vertical");
        float yaw = Input.GetAxis("Horizontal");

        _rigidbody.AddRelativeForce(0, 0, Thrust * ThrustMultiplier * Time.fixedDeltaTime);
        _rigidbody.AddRelativeTorque(
            pitch * PitchMultiplier * Time.fixedDeltaTime,
            yaw * YawMultiplier * Time.fixedDeltaTime,
            -yaw * YawMultiplier * 2 * Time.fixedDeltaTime
        );
    }
}