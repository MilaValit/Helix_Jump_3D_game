using UnityEngine;

public class UIGamePanel : BallEvents
{
    [SerializeField] private GameObject PassedPanel;
    [SerializeField] private GameObject DefeatPanel;

    private void Start()
    {
        PassedPanel.SetActive(false);
        DefeatPanel.SetActive(false);
    }

    protected override void OnBallCollisionSegment(SegmentType type)
    {
        if (type == SegmentType.Trap)
        {
            DefeatPanel.SetActive(true);
        }
        if (type == SegmentType.Finish)
        {
            PassedPanel.SetActive(true);
        }
    }
}
