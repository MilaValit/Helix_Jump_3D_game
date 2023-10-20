using UnityEngine;

public class ScoresCollector : BallEvents
{
    [SerializeField] private LevelProgress levelProgress;

    [SerializeField] private int scores;
    public int Scores => scores;

    [SerializeField] private int maxScores;
    public int MaxScores => maxScores;

    private int bonus = 0;
    protected override void Awake()
    {
        base.Awake();
        LoadMaxScores();
    }

    protected override void OnBallCollisionSegment(SegmentType type)
    {
        if (type == SegmentType.Empty)
        {
            scores += levelProgress.CurrentLevel + levelProgress.CurrentLevel * bonus;
            bonus++;
        }
        else
        {
            bonus = 0;
        }

        if (type == SegmentType.Finish)
        {
            if (scores > maxScores)
            {
                maxScores = scores;
                SaveMaxScores();
            }
        }
    }

    private void SaveMaxScores()
    {
        PlayerPrefs.SetInt("ScoresCollector:MaxScores", maxScores);
    }

    private void LoadMaxScores()
    {
        maxScores = PlayerPrefs.GetInt("ScoresCollector:MaxScores", 0);
    }
}
