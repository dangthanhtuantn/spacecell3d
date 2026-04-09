using UnityEngine;

public class OrbSpawner : MonoBehaviour
{
    public GameObject orbPrefab;
    public int maxOrb = 100;
    public float range = 50f;

    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Orb").Length < maxOrb)
        {
            Vector3 pos = new Vector3(
                Random.Range(-range, range),
                0,
                Random.Range(-range, range)
            );

            Instantiate(orbPrefab, pos, Quaternion.identity);
        }
    }
}
