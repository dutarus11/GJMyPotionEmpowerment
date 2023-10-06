using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    public Text scoreText;
    public Text topScoreText;
    public static int scoreCount;
    public static int topScoreCount;
    void Start()
    {
        if (PlayerPrefs.HasKey("Top Score"))
        {
            topScoreCount = PlayerPrefs.GetInt("Top Score");
        }
    }

    // Update is called once per frame
    void Update()
    {
      
        if (scoreCount > topScoreCount)
        {
            topScoreCount = scoreCount;
            PlayerPrefs.SetInt("TopScore", topScoreCount);
        }
        scoreText.text = "Score: " + scoreCount;
        topScoreText.text = "Top Score: " + topScoreCount;
        //scoreText.text = "Score: " + Mathf.Round(scoreCount);
        //scoreText.text = "Top Score: " + Mathf.Round(topScoreCount);
    }
}
