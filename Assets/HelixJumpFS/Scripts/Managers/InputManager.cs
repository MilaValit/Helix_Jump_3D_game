using UnityEngine;

public class InputManager : BallEvents
{
    [SerializeField] private MouseRotator InputRotator;
    protected override void OnBallCollisionSegment(SegmentType type)
    {
        if (type == SegmentType.Trap || type == SegmentType.Finish)
        {
            InputRotator.enabled = false;
        }
    }
}
