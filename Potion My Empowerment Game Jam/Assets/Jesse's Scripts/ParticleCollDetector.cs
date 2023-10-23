using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class ParticleCollDetector : MonoBehaviour
{
       
    //Detects particles collider & destroys the enemies 
   
    void OnCollisionEnter(Collision collision)
    {
        var obj = collision.gameObject;
        Debug.Log("In collision enter");
        
        if (obj.tag == "Enemy")
        {
            Debug.Log("IN DESTROY CHECK");
            Destroy(obj);
        }       
    }   
}

    

