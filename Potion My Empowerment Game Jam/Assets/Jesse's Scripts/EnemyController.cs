using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyController : MonoBehaviour
{
    //The Enemy AI Class 

    Transform player;
    NavMeshAgent agent;
    public float checkRate = 1f;
    float nextCheck;
    public float num = 2f;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        agent = gameObject.GetComponent<NavMeshAgent>();
        agent.updateRotation = true; 
        agent.stoppingDistance = agent.radius * num; 
        InvokeRepeating("FollowPlayer", checkRate, checkRate); 
    }

    //follows the player
    void FollowPlayer()
    {
        agent.SetDestination(player.position);  
    }
   
}
