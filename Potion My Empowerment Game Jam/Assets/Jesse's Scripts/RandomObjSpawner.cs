using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class RandomObjSpawner : MonoBehaviour
{

    public GameObject newPotion;
    EnemySpawner spawned;
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 randomSpwnPos = new Vector3(Random.Range(-5, 2), 0, Random.Range(-5, 2));
            Instantiate(newPotion, randomSpwnPos, Quaternion.identity);
           // spawned.EnemySpawning();
        }
        //if (newPotion = null)
        //{
        //    spawned.EnemySpawning();
        //}
       
    }

   





}
