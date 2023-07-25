using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    public NavMeshAgent agent;

    private void Start()
    {
        agent.updateRotation = false;
    }

    private void Update()
    {
        float inputX = Input.GetAxisRaw("Horizontal");
        float inputY = Input.GetAxisRaw("Vertical");

        Vector3 move = new Vector3(inputX, 0, inputY);
        move = transform.TransformDirection(move);
        agent.destination = transform.position + move;
    }
}
