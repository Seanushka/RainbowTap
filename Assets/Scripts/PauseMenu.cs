using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public GameObject pause;
    public GameObject pauseButton;
    public AudioMixer MainMixer;
    public Slider volumeSlider;
    private float timeScaleNow;

    public void OnPressEnterMenu()
    {
        timeScaleNow = Time.timeScale;
        Time.timeScale = 0;
        pause.SetActive(true);
        pauseButton.SetActive(false);
    }

    public void CloseMenu()
    {
        Time.timeScale = timeScaleNow;
        pause.SetActive(false);
        pauseButton.SetActive(true);
    }
}
