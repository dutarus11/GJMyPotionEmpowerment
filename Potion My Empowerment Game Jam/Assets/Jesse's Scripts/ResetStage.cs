using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ResetStage : MonoBehaviour
{
    //Resets the game 

    private ScoreSystem scoreSystem;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       scoreSystem = FindObjectOfType<ScoreSystem>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Colldier WORKS!");
            SceneManager.LoadScene(1);
            ScoreSystem.scoreCount = 0;
        }

    }
}
