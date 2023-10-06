using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class PowerUp : MonoBehaviour
{
    //public GameObject activateObj;
    //public float seconds = 3f;
    private void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Colldier WORKS!");
            Destroy(gameObject);
            ScoreSystem.scoreCount += 50;
        }

    }
    //void Update()
    //{
    //    activateObj.SetActive(true);
    //    PlayerAttackPower.Instance.Shoot();
    //    IEnumerator Waiting()
    //    {
    //        yield return new WaitForSeconds(seconds);

    //        activateObj.SetActive(false);

    //    }
    //}     
   
}
