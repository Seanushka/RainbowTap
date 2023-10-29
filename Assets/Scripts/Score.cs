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

    public GameObject Spawner;
    float spawnerTimer;


    public float speed10 = 0.75f;
    public float speed25 = 0.75f;
    public float speed50 = 0.75f;
    public float speed100 = 0.75f;



    void Start()
    {
        scoreAmount = 0;
        spawnerTimer = Spawner.GetComponent<Spawner>().timerReset; // timerReset = 3f In Spawner script
    }

    void Update()
    {
        score.text = scoreAmount.ToString();

        if (scoreAmount == 10)
        {
            Spawner.GetComponent<Spawner>().timerReset = spawnerTimer * speed10; //timerreset = 3f * 0.75f = 2.25f
        }

        if (scoreAmount == 25)
        {
            Spawner.GetComponent<Spawner>().timerReset = spawnerTimer * speed25; //timerreset = 3f * 0.75f = 2.25f
        }

        if (scoreAmount == 50)
        {
            Spawner.GetComponent<Spawner>().timerReset = spawnerTimer * speed50; //timerreset = 3f * 0.75f = 2.25f
        }

        if (scoreAmount == 100)
        {
            Spawner.GetComponent<Spawner>().timerReset = spawnerTimer * speed100; //timerreset = 3f * 0.75f = 2.25f
        }

    }

    public void Addscore()
    {
        scoreAmount++;
    }
}

