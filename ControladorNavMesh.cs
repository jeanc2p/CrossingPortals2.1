using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class ControladorNavMesh : MonoBehaviour
{
    [HideInInspector]
    public Transform PerseguirObjetivo;

    private NavMeshAgent navMeshAgent;
    // Start is called before the first frame update
    void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    public void ActualizarPuntoDestinoNavMesh(Vector3 puntoDestino)
    {
        navMeshAgent.destination = puntoDestino;
        navMeshAgent.isStopped = false;
    }
    public void ActualizarPuntoDestinoNavMesh()
    {
        ActualizarPuntoDestinoNavMesh(PerseguirObjetivo.position);
    }
    public void DetenerNavMeshAgent()
    {
        navMeshAgent.isStopped = true;
    }

    public bool Llegamos()
        {
        return navMeshAgent.remainingDistance <= navMeshAgent.stoppingDistance && !navMeshAgent.pathPending;
    }
}
