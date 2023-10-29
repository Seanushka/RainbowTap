using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public GameObject pause;
    public AudioMixer MainMixer;
    public Slider volumeSlider;

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
