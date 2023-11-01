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
    public float SpeedUpTimer = 10f;
    public float speedUpTimerReset;
    public float speedUpAmount = 1.1f;

    void Start()
    {
        speedUpTimerReset = SpeedUpTimer;
        SpeedUpTimer = -Time.unscaledDeltaTime;
        scoreAmount = 0;
    }

    void Update()
    {
        Debug.Log(SpeedUpTimer);
        if(SpeedUpTimer <= 0)
        {
            Time.timeScale = Time.timeScale * speedUpAmount;
            SpeedUpTimer = speedUpTimerReset;
        }
        score.text = scoreAmount.ToString();
    }

    public void Addscore()
    {
        scoreAmount++;
    }
}

