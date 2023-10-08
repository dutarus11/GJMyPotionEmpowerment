using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class PursuePlayer : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //Enemy pursues the player 
    void Update()
    {
        enemy.SetDestination(player.position);
    }
}
