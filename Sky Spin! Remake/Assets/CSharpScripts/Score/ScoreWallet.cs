using NTC.Global.Cache;
using UnityEngine;

public class ScoreWallet : MonoCache
{
    [SerializeField] private UIViewer _scoreViewer;

    public int Score { get; private set; }
    public int Record { get; private set; }

    private void Awake()
    {
        Score = 0;
    }

    private void CheckRecord()
    {
        if (Record > Score)
            Record = Score;
    }

    public void ReceiveScore()
    {
        Score++;
        CheckRecord();
        _scoreViewer.UpdateText(Score);
    }
}
