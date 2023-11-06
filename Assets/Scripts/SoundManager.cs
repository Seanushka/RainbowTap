using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{

    [SerializeField] Slider volumeSilder;
    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("musicVolume")) // = false
        {
            PlayerPrefs.SetFloat("musicVolume", 1);
            Load();
        }

        else
        {
            Load();
        }
    }

    public void ChangeVolume()
    {
        AudioListener.volume = volumeSilder.value;
        Safe();
    }

    private void Load()
    {
        volumeSilder.value = PlayerPrefs.GetFloat("musicVolume");
    }

    private void Safe()
    {
        PlayerPrefs.SetFloat("musicVolume",volumeSilder.value);
    }
}
