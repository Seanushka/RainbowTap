using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Restart : MonoBehaviour
{
    Scene MainScene;
    // Start is called before the first frame update
    void Start()
    {
        MainScene = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPress()
    {
        SceneManager.LoadScene(MainScene.name);
        Time.timeScale = 1;
    }
}
