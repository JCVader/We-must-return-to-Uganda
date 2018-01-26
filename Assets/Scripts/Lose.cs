using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Lose : MonoBehaviour
{
    void OnTriggerEnter2D()
    {
        SceneManager.LoadScene("3 Lose");
    }
}
