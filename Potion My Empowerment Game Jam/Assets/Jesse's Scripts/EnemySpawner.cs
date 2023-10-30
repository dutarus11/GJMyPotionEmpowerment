using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    //Enemy Spawning Class 
    public GameObject enemy;
    public Transform enemyPos;

    public float x = 1.21f, y = 0.74f, z = 1.25f;

    RandomObjSpawner potion;
   
    void Update()
    {
       EnemySpawning();
    }

    //Enemy spawning 
    public void EnemySpawning()
    {     
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(enemy, new Vector3(x, y, z), Quaternion.identity);
            Debug.Log("Spawn Message Succeeded!");
        }

    }
}
