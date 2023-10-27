using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyController : MonoBehaviour
{

    Transform player;
    NavMeshAgent agent;
    public float checkRate = 1f;
    float nextCheck;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        agent = gameObject.GetComponent<NavMeshAgent>();
        agent.updateRotation = true; // rotate the agent always to the player
        agent.stoppingDistance = agent.radius * 2f; // we do this so the agent dont move the player away
        InvokeRepeating("FollowPlayer", checkRate, checkRate); // follows the player again every checkRate seconds
    }

    void FollowPlayer()
    {
        agent.SetDestination(player.position);  // should do the job if your navmesh is setup correctly
    }
    //Transform playerTransform;
    //UnityEngine.AI.NavMeshAgent myNavmesh;
    //public float checkRate = 0.01f;
    //float nextCheck;

    //// Start is called before the first frame update
    //void Start()
    //{
    //    if (GameObject.FindGameObjectWithTag("Player").activeInHierarchy)
    //        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;


    //    myNavmesh = gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>();
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    if (Time.time > nextCheck)
    //        nextCheck = Time.time + checkRate;
    //    FollowPlayer();
    //}

    //void FollowPlayer()
    //{
    //    myNavmesh.transform.LookAt(playerTransform);
    //    myNavmesh.destination = playerTransform.position;
    //}

    //public float findRadius = 10;
    //public float y = 0f;
    //public float num = 10f;

    //Transform target;
    ////Transform target;
    //NavMeshAgent agent;

    //public NavMeshAgent enemy;
    //public Transform player;

    //void Start()
    //{
    //    //target = PlayerManager.instance.player.transform;
    //    //agent = GetComponent<NavMeshAgent>();
    //}


    //void Update()
    //{
    //    EnemyMovement();
    //}

    ////Enemy movement 
    //void EnemyMovement()
    //{
    //    enemy.SetDestination(player.position);
    //    //float distance = Vector3.Distance(target.position, transform.position);

    //    //if (distance <= findRadius)
    //    //{
    //    //    agent.SetDestination(target.position);
    //    //    if (distance <= agent.stoppingDistance)
    //    //    {
    //    //        //attack player
    //    //        //face the player 
    //    //        FacePlayer();
    //    //    }
    //    //}
    //    //if (distance == null)
    //    //{
    //    //    Debug.Log("NO DISTANCE VALUE FOUND!!");
    //    //}
    //    //transform.position = Vector3.MoveTowards(this.transform.position, target.position, num * Time.deltaTime);
    //}

    ////Enemy facing the player/target 
    ////void FacePlayer()
    ////{
    ////    Vector3 direction = (target.position - transform.position).normalized;
    ////    Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, y, direction.z));
    ////    transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
    ////}

    ////Visual radius of the enemy 
    ////private void OnDrawGizmosSelected()
    ////{
    ////    Gizmos.color = Color.yellow;
    ////    Gizmos.DrawWireSphere(transform.position, findRadius);
    ////}
}
