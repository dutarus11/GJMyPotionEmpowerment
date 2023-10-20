using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class ParticleCollDetector : MonoBehaviour
{

    //Detects particles collider 
    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.name == "ForestBrazzierBlue")
    //    {
    //        Debug.Log("Particle collision SUCCESS!");
    //        //Destroy(other.gameObject);
    //    }
    //}
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "ForestBrazzierBlue")
        {
            Debug.Log("Particle collision SUCCESS!");
        }
    }
    //void OnParticleCollision(GameObject other)
    //{
    //    Debug.Log("Particle collision SUCCESS!");
    //}
}

    

