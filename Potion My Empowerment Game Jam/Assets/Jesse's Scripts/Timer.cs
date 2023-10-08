using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timeRemaining;
    public float timeOut = 0;
    void Update()
    {        
        Timing();
    }

    //The Timer 
    public void Timing()
    {
        timeRemaining -= Time.deltaTime;
        if (timeRemaining <= timeOut)
        {
            Debug.Log("Time is up!");
            Application.Quit();
        }
    }
}
