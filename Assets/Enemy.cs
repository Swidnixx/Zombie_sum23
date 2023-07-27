using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    Transform player;
    NavMeshAgent agent;
    int health = 30;
    public int dmg = 15;
    Animator animator;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = FindObjectOfType<Player>().transform;
        animator = GetComponent<Animator>();

       // agent.updatePosition = false;
    }

    private void Update()
    {
        agent.destination = player.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            other.GetComponent<Player>().Damage();
        }
        else if(other.CompareTag("Bullet"))
        {
            Damage(dmg);
        }

    }

    void Damage(int dmg)
    {
        health = health - dmg;
        if(health <= 0)
        {
            animator.SetTrigger("Death");
            Debug.Log("Zombie Dead");
            Destroy(gameObject, 8);
        }
    }

}
