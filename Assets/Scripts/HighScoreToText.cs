using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreToText : MonoBehaviour
{
    public static int currentScore;
    public Text highScore;
    

    void Start()
    {
       highScore.text = "High Score : " + PlayerPrefs.GetInt("HighScore");
        highScore = GameObject.FindGameObjectWithTag("HighScore").GetComponent<Text>();
        currentScore = PlayerPrefs.GetInt("Skor");
        //PlayerPrefs.SetInt("HighScore", 0); // kaydedilen highscore2u sıfırlar

    }

    

    private void Update()
    {
    
        if (currentScore > PlayerPrefs.GetInt("HighScore", 0    ))
        {
            PlayerPrefs.SetInt("HighScore", currentScore);
            highScore.text = "High Score : " + currentScore;

        }

    }
}
