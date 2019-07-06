using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;

public class MoveTo : MonoBehaviour
{
    private Transform enemyTransform;
    public GameObject goal;
    public int actualTarget = 0;
    float speed = 5f;

    private void Awake()
    {
        enemyTransform = transform;
    }
    public void Move()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = goal.transform.position;
    }
}
