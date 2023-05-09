using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EulerSample : MonoBehaviour
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
        transform.localEulerAngles = new Vector3(_x, _y, _z);
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
        transform.localEulerAngles = new Vector3(_x, _y, _z);
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
        transform.localEulerAngles = new Vector3(_x, _y, _z);
    }
}