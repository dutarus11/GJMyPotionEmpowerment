using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollider : MonoBehaviour
{
    // The Enemy Collider Class 
    ScoreSystem decreasePoints;
    public int num = 5;
    private void Start()
    {
        decreasePoints = GameObject.FindGameObjectWithTag("UI Objects").GetComponent<ScoreSystem>();
    }

    private void OnTriggerEnter(Collider other)
    {
       
            var obj = other.gameObject;
            //Debug.Log("In collision enter");

            if (obj.tag == "Enemy")
            {
                Debug.Log("PLAYER COLLIDER WORKS!!!!");
                decreasePoints.SubtractPoints(num);
            }
        
    }
  
}
