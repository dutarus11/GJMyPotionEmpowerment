using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public Transform enemyPos;

    public float x = 1.21f, y = 0.74f, z = 1.25f;

    RandomObjSpawner potion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       EnemySpawning();
    }

    //Enemy spawning 
    public void EnemySpawning()
    {
        //if (potion.newPotion == null)
        //{
        //    Instantiate(enemy, new Vector3(x, y, z), Quaternion.identity);
        //    Debug.Log("Spawn Message Succeeded!");
        //}
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(enemy, new Vector3(1.21f, 0.74f, 1.25f), Quaternion.identity);
            Debug.Log("Spawn Message Succeeded!");
        }

    }
}
