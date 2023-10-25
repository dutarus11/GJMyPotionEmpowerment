using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollider : MonoBehaviour
{
    ScoreSystem decreasePoints;
    private void Start()
    {
        decreasePoints = GameObject.FindGameObjectWithTag("UI Objects").GetComponent<ScoreSystem>();
    }
    void OnCollisionEnter(Collision collision)
    {
        var obj = collision.gameObject;
        //Debug.Log("In collision enter");

        if (obj.tag == "Player")
        {
            Debug.Log("PLAYER COLLIDER WORKS!!!!");
            decreasePoints.SubtractPoints(10);
        }
    }
}
