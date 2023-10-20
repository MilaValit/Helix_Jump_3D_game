using UnityEngine;
using UnityEngine.UI;

public class UIScoreText : BallEvents
{
    [SerializeField] private ScoresCollector scoresCollector;
    [SerializeField] private Text scoresText;
    [SerializeField] private Text maxScoresText;
    [SerializeField] private string markMaxScoreText;

    private void Start()
    {
        maxScoresText.text = markMaxScoreText + " " + scoresCollector.MaxScores;
    }

    protected override void OnBallCollisionSegment(SegmentType type)
    {
        if (type != SegmentType.Trap )
        {
            scoresText.text = scoresCollector.Scores.ToString();
        }

        if (type == SegmentType.Finish)
        {
            maxScoresText.text = markMaxScoreText + " " + scoresCollector.MaxScores;
        }
    }
}
