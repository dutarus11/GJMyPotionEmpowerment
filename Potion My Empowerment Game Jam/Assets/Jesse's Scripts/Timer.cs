using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 30;
    void Update()
    {
        timeRemaining -= Time.deltaTime;

        if (timeRemaining <= 0)
        {
            
            Debug.Log("Time is up!");
            Application.Quit();
        }
    }
}
