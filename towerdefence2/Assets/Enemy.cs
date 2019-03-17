using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 5f;
    private Transform target;
    private int wavepointIndex = 0;
     public void Start()
    {
        target = Waypoints.points[0];
    }
    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);
        if(Vector3.Distance(transform.position,target.position)<=0.2f)
        {
            GetNextWaypoint();
            return;
        }
    }
    void GetNextWaypoint()
    {
        if(wavepointIndex>=Waypoints.points.Length-2)
        {
            Destroy(gameObject);
        }
        wavepointIndex++;
        target = Waypoints.points[wavepointIndex];

    }
}
