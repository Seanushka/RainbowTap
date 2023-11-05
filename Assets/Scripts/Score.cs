using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI score;
    public int scoreAmount;
    public float speedUpAmount = 1.1f;
    private float countdownToSpeedUp;

    void Start()
    {
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
    }
}

