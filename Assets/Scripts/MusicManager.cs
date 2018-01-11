using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour
{
    public AudioClip[] audioClip;
    private AudioSource audioSource;

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnLevelFinishedLoading;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnLevelFinishedLoading;
    }
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnLevelFinishedLoading(Scene scene, LoadSceneMode mode)
    {
        AudioClip currentClip = audioClip[scene.buildIndex];

        
        if(currentClip)
        {
            audioSource.clip = currentClip;
            audioSource.loop = true;
            audioSource.Play();
        }
    }


}
