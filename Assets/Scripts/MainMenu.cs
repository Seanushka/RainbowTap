using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        print("we playing");
        SceneManager.LoadScene(1); 
        
    }

    public void QuitGame()
    {
        print("we out");
        Application.Quit();
        
    }

}
