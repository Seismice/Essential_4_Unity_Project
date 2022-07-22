using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshMove : MonoBehaviour
{
    [SerializeField] private Transform EndPoint;

    private NavMeshAgent _navMeshAgent;
    void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        GetComponent<Animator>().SetBool("OnOffMeshLink", _navMeshAgent.isOnOffMeshLink);

        _navMeshAgent.SetDestination(EndPoint.position);
    }
}
