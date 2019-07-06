using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform enemyTransforms;
    public List<Transform> waypoinTransforms;
    [SerializeField]
    private int actualWaypoint = 0;
    [SerializeField]
    private float movementSpeed = 5f;

    private void Awake()
    {
        enemyTransforms = transform;
    }
    public void Move()
    {
        Vector3 actualWaypointDisplacement = waypoinTransforms[actualWaypoint].position - enemyTransforms.position;
        float distanceToWaypoint = actualWaypointDisplacement.magnitude;
        if (distanceToWaypoint>1)
        {
            Vector3 directionVector = actualWaypointDisplacement.normalized;
            enemyTransforms.position += directionVector * movementSpeed * Time.deltaTime;
        }
        else
        {
            actualWaypoint++;
            if (actualWaypoint >= waypoinTransforms.Count)
                actualWaypoint = 0;
        }
    }
}
