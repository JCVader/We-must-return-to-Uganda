using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour
{
    public AudioClip[] audioClip;
    private AudioSource audioSource;

    void Awake()
    {
        DontDestroyOnLoad(gameObject); // żeby go nie niszczyło przy zmianie sceny
    }

    void Start()
    {
        audioSource = GetComponent<AudioSource>(); // pobiera bieżący audio source po załadowaniu sceny
    }

    void OnLevelWasLoaded(int index) // funkcja przyjmuje numer indeksu sceny w build settings
    {
        if(audioClip[index]) // jeśli coś jest w tablicy w danym indeksie
        {
            audioSource.clip = audioClip[index]; // przypisuje audio source dźwięk o danym indeksie
            audioSource.loop = true; // zapętla go
            audioSource.Play(); // i go włącza
        }
    }

    public void ChangeVolume(float volume) //żeby zmieniało głośność audio source z options controllera
    {
        audioSource.volume = volume;
    }

}