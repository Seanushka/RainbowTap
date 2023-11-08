using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public int sceneNumber;
    public void LoadScene()
    {
        SceneManager.LoadScene(sceneNumber);  
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
