using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicObstacle : MonoBehaviour
{
    public GameObject[] waypoints;

    int current = 0;
    float rotspeed;
    public float speed;
    float wpradius = 1;
    private void Update()
    {
        if (Vector3.Distance(waypoints[current].transform.position,transform.position) > wpradius)
        {
            current = Random.Range(0, waypoints.Length);
            if (current >= waypoints.Length)
            {
                current = 0;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, waypoints[current].transform.position, Time.deltaTime * speed);
    }
}
