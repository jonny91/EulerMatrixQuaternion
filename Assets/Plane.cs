/*************************************************************************************
 *
 * 文 件 名:   Plane.cs
 * 描    述: 
 * 
 * 创 建 者：  洪金敏 
 * 创建时间：  2023-05-07 01:34:22
*************************************************************************************/

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{
    public Transform L;
    public Transform R;
    public Transform EffectPrefab;

    private Transform EffectL;
    private Transform EffectR;

    private void Start()
    {
        EffectL = Instantiate(EffectPrefab);
        EffectR = Instantiate(EffectPrefab);
    }

    private void FixedUpdate()
    {
        var posL = L.localToWorldMatrix.MultiplyPoint3x4(new Vector3(0, 0, -.5f));
        EffectL.transform.position = posL;

        var posR = R.localToWorldMatrix.MultiplyPoint3x4(new Vector3(0, 0, -.5f));
        EffectR.transform.position = posR;
    }
}