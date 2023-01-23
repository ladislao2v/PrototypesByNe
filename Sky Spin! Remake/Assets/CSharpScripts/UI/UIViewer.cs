using NTC.Global.Cache;
using TMPro;
using UnityEngine;

public class UIViewer : MonoCache
{
    [SerializeField] private TextMeshProUGUI _textMeshProUGUI;

    public void UpdateText(int value)
    {
        _textMeshProUGUI.text = value.ToString();
    }
}
