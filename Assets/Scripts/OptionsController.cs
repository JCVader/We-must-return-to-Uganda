using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{
    public Slider volumeSlider;
    public LevelManager levelManager; // level manager
    private MusicManager musicManager; // music manager

    void Start()
    {
        musicManager = FindObjectOfType<MusicManager>(); // szuka czy jest na scenie music manager
        volumeSlider.value = PlayerPrefsManager.GetVolume(); // ustawia volume sliderowi wartość zapisaną w player prefie

    }

    public void SaveExit()
    {
        PlayerPrefsManager.SetVolume(volumeSlider.value); // po kliknięciu wysyła do player prefa wartość ze slidera
        levelManager.LoadLevel("1 Main"); // i ładuje główne menu
    }

    public void Defaults()
    {
        volumeSlider.value = 0.5f; // ustawia slider głośności na domyślne 0.5
    }

    void Update()
    {
        musicManager.ChangeVolume(volumeSlider.value); // wysyła do music managera wartość slidera co klatkę żeby na bieżąco zmieniał głośność
    }



}
