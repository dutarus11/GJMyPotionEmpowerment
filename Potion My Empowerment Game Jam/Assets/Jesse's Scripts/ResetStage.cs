using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ResetStage : MonoBehaviour
{
    //Resets the game 

    private ScoreSystem scoreSystem;
    public int num = 0;
    void Start()
    {
        
    }
    void Update()
    {
       scoreSystem = FindObjectOfType<ScoreSystem>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Colldier WORKS!");
            ResetScene(); 
            ScoreSystem.scoreCount = num;
        }

    }

    public void ResetScene()
    {
        SceneManager.LoadScene(1);
    }
}
