using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    float time = 8.3f;
    
    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            Invoke("LoadNextLevel", time);
        }
    }
    public void LoadLevel(string level)
    {
        Debug.Log("Level loaded: " + level);
        SceneManager.LoadScene(level);
    }

    public void QuitGame()
    {
        Debug.Log("Quit requested");
        Application.Quit();
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
