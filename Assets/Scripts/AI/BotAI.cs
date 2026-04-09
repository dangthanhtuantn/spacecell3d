using UnityEngine;

public class BotAI : MonoBehaviour
{
    public float speed = 10f;

    void Update()
    {
        GameObject[] orbs = GameObject.FindGameObjectsWithTag("Orb");

        if (orbs.Length == 0) return;

        GameObject target = orbs[Random.Range(0, orbs.Length)];
        Vector3 dir = (target.transform.position - transform.position).normalized;

        transform.position += dir * speed * Time.deltaTime;
    }
}
