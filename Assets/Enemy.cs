using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    Transform player;
    NavMeshAgent agent;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = FindObjectOfType<Player>().transform;

       // agent.updatePosition = false;
    }

    private void Update()
    {
        agent.destination = player.position;
    }
}
