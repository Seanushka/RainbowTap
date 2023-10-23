using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float timer = 3f;
    float timerReset;
    public GameObject[] cubes = new GameObject [4];

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
            CubeSpawn();
            timer = timerReset;
        }
    }

    void CubeSpawn()
    {
        Vector2 spawnPos = new Vector2(Random.Range(-2, 3), 4);
        
        Instantiate(cubes[Random.Range(0,4)],spawnPos,Quaternion.identity);
        Debug.Log(spawnPos);
    }
}