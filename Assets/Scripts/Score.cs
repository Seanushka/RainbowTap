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

    void Start()
    {
        scoreAmount = 0;
    }

    void Update()
    {
        score.text = scoreAmount.ToString();
    }

    public void Addscore()
    {
        scoreAmount++;
    }
}

