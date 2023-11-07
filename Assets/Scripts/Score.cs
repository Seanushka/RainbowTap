using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI score;
    public TextMeshProUGUI highScore;
    public int scoreAmount;
    public float speedUpAmount = 1.1f;
    private float countdownToSpeedUp;
    float difVal = 10;

    void Start()
    {
        UpdateHighScore();
        scoreAmount = 0;
    }

    void Update()
    {
        if (countdownToSpeedUp == difVal)
        {
            Time.timeScale = Time.timeScale * speedUpAmount;
            countdownToSpeedUp = 0;
            difVal = difVal + 5;
            if(Time.timeScale < 15)
            {
                Time.timeScale = 14;
                difVal = 10000;
            }
        }
        score.text = $"Score:" + scoreAmount.ToString();
    }

    public void Addscore()
    {
        scoreAmount++;
        countdownToSpeedUp++;
        CheckHighScore();
    }
    
    public void CheckHighScore()
    {
        if (scoreAmount > PlayerPrefs.GetInt("High score", 0))
        {
            PlayerPrefs.SetInt("High score", scoreAmount);
        }
    }

    public void UpdateHighScore()
    {
        highScore.text = $"HighScore: {PlayerPrefs.GetInt("High score", 0)}";
    }
}

