using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pause;

    public void OnPressEnterMenu()
    {
        Time.timeScale = 0;
        pause.SetActive(true);
    }

    public void CloseMenu()
    {
        Time.timeScale = 1;
        pause.SetActive(false);
    }
}
