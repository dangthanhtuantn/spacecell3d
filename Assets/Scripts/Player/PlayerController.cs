using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 15f;
    public float smooth = 8f;

    Vector3 velocity;

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Plane plane = new Plane(Vector3.up, Vector3.zero);

        if (plane.Raycast(ray, out float distance))
        {
            Vector3 target = ray.GetPoint(distance);
            Vector3 dir = (target - transform.position).normalized;

            velocity = Vector3.Lerp(velocity, dir * speed, smooth * Time.deltaTime);
            transform.position += velocity * Time.deltaTime;
        }
    }
}
