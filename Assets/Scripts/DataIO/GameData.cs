using UnityEngine.UI;
using UnityEngine;

[System.Serializable]
public class GameData
{
    public float color_r;
    public float color_g;
    public float color_b;
    public float color_a;

    public GameData(Color color)
    {
        color_a = color.a;
        color_b = color.b;
        color_r = color.r;
        color_g = color.g;
    }

    public Color getColor()
    {
        return new Color(color_r, color_g, color_b, color_a);
    }
}