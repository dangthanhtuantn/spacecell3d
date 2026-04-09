using UnityEngine;

public class Orb : MonoBehaviour
{
    public float value = 0.3f;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerStats>().Grow(value);
            Destroy(gameObject);
        }
    }
}
