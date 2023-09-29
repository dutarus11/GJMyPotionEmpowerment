using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleCollDetector : MonoBehaviour
{
    private void OnParticleCollision(GameObject other)
    {
        Debug.Log("Particle collision SUCCESS!");
    }
}
