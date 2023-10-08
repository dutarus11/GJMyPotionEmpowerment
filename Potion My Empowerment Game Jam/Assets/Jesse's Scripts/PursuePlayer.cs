using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class PursuePlayer : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Transform player;
  
    //Enemy pursues the player 
    void Update()
    {
        enemy.SetDestination(player.position);
    }
}
