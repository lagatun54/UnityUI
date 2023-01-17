using UnityEngine;

public class UIWidgetLifeBar : MonoBehaviour
{
    [SerializeField] private ProgressBar _progressBar;
    [SerializeField] private Interface _interface;

    private void OnEnable()
    {
        this._progressBar.SetValue(_interface.healthNormalized);
        _interface.OnPlayerHealthValueChangedEvent += OnPlayerHealthValueChanged;
    }

    private void OnPlayerHealthValueChanged(float newValueNormalized) => 
        this._progressBar.SetValue(newValueNormalized);

   

    private void OnDisable()
    {
        if (_interface)
            _interface.OnPlayerHealthValueChangedEvent += OnPlayerHealthValueChanged;
    }
}
