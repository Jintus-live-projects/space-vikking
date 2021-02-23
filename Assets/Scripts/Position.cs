using UnityEngine;

[System.Serializable]
public class Position
{
    public float radius;

    [SerializeField, Range(0f, 360f)]
    public float angle;

    public Position(float radius, float angle)
    {
        this.radius = radius;
        this.angle = angle;
    }
}
