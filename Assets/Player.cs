using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    public NavMeshAgent agent;
    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
       // agent.updateRotation = false;
    }

    private void Update()
    {
        float inputX = Input.GetAxisRaw("Horizontal");
        float inputY = Input.GetAxisRaw("Vertical");

        Vector3 move = new Vector3(inputX, 0, inputY);
        move = transform.TransformDirection(move);
        agent.destination = transform.position + move;

        animator.SetFloat("speed", agent.velocity.magnitude);
        //Debug.Log("Speed: " + agent.velocity.magnitude);
    }

    int health = 100;
    internal void Damage()
    {
        health -= 50;

        if(health <= 0)
        {
            health = 0;
            Debug.Log("Game Over");
        }
    }

}
