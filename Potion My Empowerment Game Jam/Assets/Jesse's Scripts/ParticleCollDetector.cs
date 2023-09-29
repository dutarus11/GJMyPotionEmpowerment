using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleCollDetector : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Cube")
        {
            Debug.Log("Particle collision SUCCESS!");
        }
    }
    //void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.name == "Cube")
    //    {
    //        Debug.Log("Particle collision SUCCESS!");
    //    }
        

    //}
    //private void OnParticleCollision(GameObject other)
    //{
    //    Debug.Log("Particle collision SUCCESS!");
    //}
}
