using UnityEngine;

public enum SegmentType
{
    Default,
    Trap,
    Empty,
    Finish
}

[RequireComponent(typeof(MeshRenderer))]
public class Segment : MonoBehaviour
{
    [SerializeField] private Material trapMaterial;
    [SerializeField] private Material finishMaterial;
    private Floor floor;

    [SerializeField] private SegmentType type;

    private MeshRenderer meshRenderer;
    public SegmentType Type => type;
    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        floor = GetComponentInParent<Floor>();
    }
    public void SetTrap()
    {
        meshRenderer.enabled = true;
        meshRenderer.material = trapMaterial;

        type = SegmentType.Trap;
    }
    public void SetEmpty()
    {
        meshRenderer.enabled = false;

        type = SegmentType.Empty;
    }
    public void SetFinish()
    {
        meshRenderer.enabled = true;
        meshRenderer.material = finishMaterial;

        type = SegmentType.Finish;
    }
    public void Crash()
    {
        for (int i = 0; i < floor.DefaultSegments.Count; i++)
        {
            floor.DefaultSegments[i].GetComponent<Rigidbody>().isKinematic = false;
        }
    }
}
