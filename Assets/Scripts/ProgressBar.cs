using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    [SerializeField] private Image _imageFiller;
    [SerializeField] private Text _textValue;

    public void SetValue(float valueNormalized)
    {
        this._imageFiller.fillAmount = valueNormalized;

        var valueInPercent = Mathf.RoundToInt(valueNormalized * 100f);
        this._textValue.text = $"{valueInPercent}%";
    }
}
