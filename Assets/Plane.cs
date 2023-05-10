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

    private Vector3 _offset = new Vector3(0, 0, 0.1f);
    private Quaternion _originRot;

    private void Start()
    {
        _originRot = EffectPrefab.localRotation;
        EffectL = Instantiate(EffectPrefab, OtherSpace);
        EffectR = Instantiate(EffectPrefab,OtherSpace);
    }

    private void Update()
    {
        EffectL.transform.position = L.position + _offset;
        EffectR.transform.position = R.position + _offset;
        EffectL.transform.rotation = L.rotation;
        EffectR.transform.rotation = R.rotation;

        // var posWorldL = L.localToWorldMatrix.MultiplyPoint3x4(_offset);
        // EffectL.transform.localPosition = OtherSpace.worldToLocalMatrix.MultiplyPoint3x4(posWorldL);
        // EffectL.transform.localRotation = Quaternion.Euler(_originRot.eulerAngles + L.rotation.eulerAngles - OtherSpace.eulerAngles);
        //
        // var posWorldR = R.localToWorldMatrix.MultiplyPoint3x4(_offset);
        // EffectR.transform.localPosition = OtherSpace.worldToLocalMatrix.MultiplyPoint3x4(posWorldR);
        // EffectR.transform.localRotation = Quaternion.Euler(_originRot.eulerAngles + R.rotation.eulerAngles - OtherSpace.eulerAngles);
        
      
        // var posWorldL = L.TransformPoint(_offset);
        // EffectL.transform.localPosition = OtherSpace.InverseTransformPoint(posWorldL);
        // EffectL.transform.localRotation = _originRot * Quaternion.Inverse(OtherSpace.rotation) * L.rotation;
    }
    
    
}