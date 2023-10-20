using UnityEngine;

public abstract class BallEvents : MonoBehaviour
{
    [SerializeField] protected BallController ballController;
    
    protected virtual void Awake()
    {
        ballController.CollisionSegment.AddListener(OnBallCollisionSegment);
    }
    private void OnDestroy()
    {
        ballController.CollisionSegment.RemoveListener(OnBallCollisionSegment);
    }

    protected virtual void OnBallCollisionSegment(SegmentType type)
    { }
}
