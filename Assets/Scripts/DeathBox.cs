using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBox : MonoBehaviour
{
    public GameObject gameOverCanvas;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;

    }
}
