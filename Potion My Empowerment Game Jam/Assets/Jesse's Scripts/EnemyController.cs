using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyController : MonoBehaviour
{
    
    public float findRadius = 10;
    public float y = 0f;
    public float num = 10f;

    Transform target;
    //Transform target;
    NavMeshAgent agent;


    void Start()
    {
        target = PlayerManager.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();
    }

    
    void Update()
    {
        EnemyMovement();
    }

    //Enemy movement 
    void EnemyMovement()
    {
        float distance = Vector3.Distance(target.position, transform.position);

        if (distance <= findRadius)
        {
            agent.SetDestination(target.position);
            if (distance <= agent.stoppingDistance)
            {
                //attack player
                //face the player 
                FacePlayer();
            }
        }

        transform.position = Vector3.MoveTowards(this.transform.position, target.position, num * Time.deltaTime);
    }

    //Enemy facing the player/target 
    void FacePlayer()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, y, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
    }

    //Visual radius of the enemy 
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, findRadius);
    }
}
