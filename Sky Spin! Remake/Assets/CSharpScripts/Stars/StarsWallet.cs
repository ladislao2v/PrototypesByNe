using NTC.Global.Cache;
using System;
using UnityEngine;

public class StarsWallet : MonoCache
{

    [SerializeField] private UIViewer _starsViewer;
    public int Stars { get; private set; }

    private void Awake()
    {
        Stars = PlayerPrefs.GetInt("SavedStars");
        _starsViewer.UpdateText(Stars);
    }

    public void SpendStars(int starsAmount)
    {
        if (starsAmount < 0 || starsAmount > Stars)
            throw new ArgumentOutOfRangeException();

        Stars -= starsAmount;
        SaveStarsCount();

        _starsViewer.UpdateText(Stars);
    }

    public void ReceiveStars(int starsAmount)
    {
        if (starsAmount < 0)
            throw new ArgumentOutOfRangeException();

        Stars += starsAmount;
        SaveStarsCount();

        _starsViewer.UpdateText(Stars);
    }

    private void SaveStarsCount()
    {
        PlayerPrefs.SetInt("SavedStars", Stars);
    }
}
