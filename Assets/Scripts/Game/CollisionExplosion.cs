using UnityEngine;

public class CollisionExplosion : MonoBehaviour
{
    public GameObject explosionFX;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            Instantiate(explosionFX, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
