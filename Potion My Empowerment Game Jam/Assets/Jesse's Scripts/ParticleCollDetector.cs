using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class ParticleCollDetector : MonoBehaviour
{

    //Detects particles collider & destroys the enemies 
    ScoreSystem increasePoints;
    private void Start()
    {
        increasePoints = GameObject.FindGameObjectWithTag("UI Objects").GetComponent<ScoreSystem>();
    }

    private void OnTriggerEnter(Collider other)
    {

        var obj = other.gameObject;
        Debug.Log("In collision enter");

        if (obj.tag == "Enemy")
        {
            Debug.Log("IN DESTROY CHECK");
            Destroy(obj);
            increasePoints.AddingPoints(15);
        }

       
    }
}

    

