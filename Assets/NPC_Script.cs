using UnityEngine;
using UnityEngine.AI;

public class NPC_Script : MonoBehaviour
{
    Vector3 targetDistance;
    NavMeshAgent agent;
    public bool isfollowTarget;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        targetDistance = GameObject.FindGameObjectWithTag("Player").GetComponent<Vector3>();   
    }

    private void Update()
    {
        agent.destination = targetDistance;
        if (isfollowTarget) 
        {
            agent.isStopped = false;
        }
        else
        {
            agent.isStopped = true;
        }
    }
}
