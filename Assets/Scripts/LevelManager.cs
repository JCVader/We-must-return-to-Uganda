using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public float loadNextScene = 1.6f;

    void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0) // tylko jeśli scena ma indeks 0 w build orderze
        {
            Invoke("LoadNextLevel", loadNextScene); // ładuje następny poziom po upływie danej ilości sekund
        }
    }
    public void LoadLevel(string level_name) // na ładowanie poziomów
    {
        SceneManager.LoadScene(level_name);
    }

    public void QuitApplication() // na wyjście z aplikacji
    {
        Debug.Log("Wychodzę z gry."); // do testu
    }

    public void LoadNextLevel() // ładowanie kolejnego poziomu w build orderze
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 
    }
	
	
}
