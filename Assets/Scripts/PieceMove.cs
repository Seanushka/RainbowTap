using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PieceMove : MonoBehaviour
{
    public float timer = 1.5f; 
    public float timerReset; // the movment speed of every piece
    float fallAmount = 0.5f;
    Vector3 piecePos;

    public GameObject scoreManager;
    float speedLV1;
    float speedLV2;
    float speedLV3;
    float speedLV4;

    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager");
        speedLV1 = scoreManager.GetComponent<Score>().speed10;
        speedLV2 = scoreManager.GetComponent<Score>().speed25;
        speedLV3 = scoreManager.GetComponent<Score>().speed50;
        speedLV4 = scoreManager.GetComponent<Score>().speed100;
        Debug.Log("start " + timer);
        
        if (scoreManager.GetComponent<Score>().scoreAmount == 10)
        {
            timer = timer * speedLV1;
            Debug.Log(timer);
        }

        timerReset = timer;
    }


    void FixedUpdate()
    {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            piecePos = this.gameObject.transform.position;
            piecePos = new Vector3(piecePos.x, piecePos.y- fallAmount, piecePos.z);
            this.gameObject.transform.position = piecePos;
            timer = timerReset;
        }

        if (scoreManager.GetComponent<Score>().scoreAmount == 10)
        {
            timerReset = timerReset * speedLV1;
            timer = timer * speedLV1;
            speedLV1 = 1f;
        }

    }
}
