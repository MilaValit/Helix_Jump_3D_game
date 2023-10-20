using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class LevelPallete
{
    public Color AxisColor;
    public Color BallColor;
    public Color DefaultSegmentColor;
    public Color TrapSegmentColor;
    public Color FinishSegmentColor;
    public Color BackgroundColor;
    public Color CameraBackgroundColor;
}

public class LevelColors : MonoBehaviour
{
    [SerializeField] private LevelPallete[] pallete;

    [SerializeField] private Material axisMaterial;
    [SerializeField] private Material ballMaterial;
    [SerializeField] private Material defaultMaterial;
    [SerializeField] private Material trapMaterial;
    [SerializeField] private Material finishMaterial;
    [SerializeField] private Image BackgroundImage;    
    [SerializeField] private new Camera camera;

    public void Start()
    {
        int index = Random.Range(0, pallete.Length);

        axisMaterial.color = pallete[index].AxisColor;
        ballMaterial.color = pallete[index].BallColor;
        defaultMaterial.color = pallete[index].DefaultSegmentColor;
        trapMaterial.color = pallete[index].TrapSegmentColor;
        finishMaterial.color = pallete[index].FinishSegmentColor;
        BackgroundImage.color = pallete[index].BackgroundColor;
        camera.backgroundColor = pallete[index].CameraBackgroundColor;
    }
}
