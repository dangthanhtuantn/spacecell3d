using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public float size = 1f;

    public void Grow(float value)
    {
        size += value;
        transform.localScale = Vector3.one * size;
    }
}
