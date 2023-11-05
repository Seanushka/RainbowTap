using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PieceMove : MonoBehaviour
{
    public float timer = 1.5f; 
    public float timerReset; 
    float fallAmount = 0.5f;
    Vector3 piecePos;
    GameObject me;

    void Start()
    {
        me = this.gameObject;
        timerReset = timer;
        me.name = FindObjectOfType<Spawner>().pieceName.ToString();
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
    }
}
