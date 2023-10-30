using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    //The Score System Class 
    public Text scoreText;
    public Text topScoreText;
    public Text winningText;
    public Text gameOverText;

    public static int scoreCount;
    public static int topScoreCount;
    public int winningScoreCount = 500;
    public int num;
   
    void Start()
    {
        PlayerPreferences();      
    }
   
    void Update()
    {
        KeepingScore();      
    }

    //Player preferences maintaining Scoring UI data 
    void PlayerPreferences()
    {
        if (PlayerPrefs.HasKey("Top Score"))
        {
            topScoreCount = PlayerPrefs.GetInt("Top Score");
        }
    }

    //Tracks the score
    void KeepingScore()
    {
        if (scoreCount > topScoreCount)
        {
            topScoreCount = scoreCount;
            PlayerPrefs.SetInt("TopScore", topScoreCount);
        }
        scoreText.text = "Score: " + scoreCount;
        topScoreText.text = "Top Score: " + topScoreCount;

        // winning conditon
        if (scoreCount == winningScoreCount)
        {
            Debug.Log("YOU WIN THE GAME!!");
        }
    }

    public void AddingPoints(int number)
    {
        num = number;
        ScoreSystem.scoreCount += number;
    }

    public void SubtractPoints(int number)
    {
        num = number;
        ScoreSystem.scoreCount -= number;
    }
}
