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

    void Start()
    {
        UpdateHighScore();
        scoreAmount = 0;
    }

    void Update()
    {
        if (countdownToSpeedUp == 10)
        {
            Time.timeScale = Time.timeScale * speedUpAmount;
            countdownToSpeedUp = 0;
        }
        score.text = scoreAmount.ToString();
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

