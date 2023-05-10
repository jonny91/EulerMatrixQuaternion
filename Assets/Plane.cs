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
    public Transform OtherSpace;

    private Transform EffectL;
    private Transform EffectR;

    private Vector3 _offset = new Vector3(0, 0, -.5f);

    private void Start()
    {
        EffectL = Instantiate(EffectPrefab, OtherSpace);
        EffectR = Instantiate(EffectPrefab, OtherSpace);
    }

    private void FixedUpdate()
    {
        EffectL.transform.position = L.position + _offset;
        EffectR.transform.position = R.position + _offset;

        // var posWorldL = L.TransformPoint(_offset);
        // EffectL.transform.localPosition = OtherSpace.InverseTransformPoint(posWorldL);
        
        // var posWorldL = L.localToWorldMatrix.MultiplyPoint3x4(_offset);
        // EffectL.transform.localPosition = OtherSpace.worldToLocalMatrix.MultiplyPoint3x4(posWorldL);
        //
        // var posWorldR = R.localToWorldMatrix.MultiplyPoint3x4(_offset);
        // EffectR.transform.localPosition = OtherSpace.worldToLocalMatrix.MultiplyPoint3x4(posWorldR);
    }
}