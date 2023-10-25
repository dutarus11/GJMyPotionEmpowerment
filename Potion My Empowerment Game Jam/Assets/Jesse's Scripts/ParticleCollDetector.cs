using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEditor.Animations;
using UnityEngine;

public class ParticleCollDetector : MonoBehaviour
{

    //Detects particles collider & destroys the enemies 
    ScoreSystem increasePoints;
    private void Start()
    {
        increasePoints = GameObject.FindGameObjectWithTag("UI Objects").GetComponent<ScoreSystem>();
    }

    void OnCollisionEnter(Collision collision)
    {
        var obj = collision.gameObject;
        Debug.Log("In collision enter");
        
        if (obj.tag == "Enemy")
        {
            Debug.Log("IN DESTROY CHECK");
            Destroy(obj);
            increasePoints.AddingPoints(25);
        }       
    }   
}

    

