using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class RandomObjSpawner : MonoBehaviour
{

    //Random Object Spawner Class 
    public GameObject newPotion;
    EnemySpawner spawned;

    public int x = -5, y = 2, num = 0;
    void Update()
    {
        PotionSpawns();                
    }

    //Spawns the potion 
    void PotionSpawns()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 randomSpwnPos = new Vector3(Random.Range(x, y), num, Random.Range(x, y));
            Instantiate(newPotion, randomSpwnPos, Quaternion.identity);
        }
    }

   





}
