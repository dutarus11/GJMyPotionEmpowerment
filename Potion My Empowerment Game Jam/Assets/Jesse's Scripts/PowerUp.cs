using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class PowerUp : MonoBehaviour
{

    //Power-up collider

    public int num = 25;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Colldier WORKS!");
            Destroy(gameObject);
            ScoreSystem.scoreCount += num;
        }

    }
  
   
}
