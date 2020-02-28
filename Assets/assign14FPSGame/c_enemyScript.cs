using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c_enemyScript : MonoBehaviour
{
    // Start is called before the first frame update
    public List<Transform> g_waypointList = new List<Transform>();
    Transform g_targetWaypoint;
    int g_targetWayPointIndex;
    float g_minDist; 
    int g_lastWaypointIndex;
    float g_movementSpeed;
    int g_targetWayPointDelta;
    void Start()
    {
        g_lastWaypointIndex = g_waypointList.Count - 1;
        g_targetWayPointIndex = 0;
        g_minDist = 0.1f;
        g_movementSpeed = 5.0f;
        g_targetWaypoint = g_waypointList[g_targetWayPointIndex];
        g_targetWayPointDelta = 1;
    }

    // Update is called once per frame
    void Update()
    {
        m_calculateMovementStats();
    }
    void m_calculateMovementStats()
    {
        Vector3 l_directionToTarget = g_targetWaypoint.position - transform.position;
        Quaternion l_rotationToTarget = Quaternion.LookRotation(l_directionToTarget);

        transform.rotation = l_rotationToTarget;
        float distance = Vector3.Magnitude(transform.position - g_targetWaypoint.position);
        
        if (distance <= g_minDist)
        {
            g_targetWayPointIndex += g_targetWayPointDelta;
            if (g_targetWayPointIndex > g_lastWaypointIndex)
            {
                g_targetWayPointDelta *= g_targetWayPointDelta;
                g_targetWayPointIndex = g_lastWaypointIndex - 1;
            }
            if (g_targetWayPointIndex < 0)
            {
                g_targetWayPointDelta *= g_targetWayPointDelta;
                g_targetWayPointIndex = 1;
            }
            g_targetWaypoint = g_waypointList[g_targetWayPointIndex];
        }

        transform.position = Vector3.MoveTowards(transform.position, g_targetWaypoint.position, g_movementSpeed * Time.deltaTime);
    }
}
