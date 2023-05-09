/*************************************************************************************
 *
 * 文 件 名:   QuaternionSample.cs
 * 描    述: 
 * 
 * 创 建 者：  洪金敏 
 * 创建时间：  2023-05-01 14:31:00
*************************************************************************************/

using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using TMPro;
using UnityEngine;

public class QuaternionSample : MonoBehaviour
{
    public bool Enable = false;
    private int _x = 0;
    private int _y = 0;
    private int _z = 0;

    [SerializeField]
    private TextMeshProUGUI XLabel;

    [SerializeField]
    private TextMeshProUGUI YLabel;

    [SerializeField]
    private TextMeshProUGUI ZLabel;

    [SerializeField]
    private TextMeshProUGUI LerpRateLabel;

    public void RotateRate(float rate)
    {
        LerpRateLabel.text = rate.ToString("F2", CultureInfo.InvariantCulture);

        RotateTo(_x, _y, _z, rate);
    }

    private void RotateTo(int x, int y, int z, float rate)
    {
        var from = Quaternion.identity;
        var to = Quaternion.Euler(x, y, z);
        rate = Mathf.Clamp01(rate);
        transform.rotation = Quaternion.Slerp(from, to, rate);
    }

    //Slider 回调监听
    public void OnXValueChanged(float value)
    {
        if (!Enable)
        {
            return;
        }

        var angle = Mathf.FloorToInt(value * 360);
        _x = angle;
        XLabel.text = _x.ToString();
    }

    public void OnYValueChanged(float value)
    {
        if (!Enable)
        {
            return;
        }

        var angle = Mathf.FloorToInt(value * 360);
        _y = angle;
        YLabel.text = _y.ToString();
    }

    public void OnZValueChanged(float value)
    {
        if (!Enable)
        {
            return;
        }

        var angle = Mathf.FloorToInt(value * 360);
        _z = angle;
        ZLabel.text = _z.ToString();
    }
}