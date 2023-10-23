using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceMove : MonoBehaviour
{
    public float timer = 1.5f;
    float timerReset;
    public float fallAmount = 0.5f;
    Vector3 piecePos;
    // Start is called before the first frame update
    void Start()
    {
        timerReset = timer;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            piecePos = this.gameObject.transform.position;
            piecePos = new Vector3(piecePos.x, piecePos.y- fallAmount, piecePos.z);
            this.gameObject.transform.position = piecePos;
            Debug.Log(piecePos);
            timer = timerReset;
        }
    }
}
