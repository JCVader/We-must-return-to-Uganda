using UnityEngine;
using System.Collections;

public class PlayerPrefsManager : MonoBehaviour
{
    const string volume = "main_volume"; // string dla głośności

    public static void SetVolume(float volumee) // ustawia głośność
    {
        if (volumee >= 0f && volumee <= 1f)
        {
            PlayerPrefs.SetFloat(volume, volumee);
        }
    }

    public static float GetVolume() // żeby zwracało głośność dla options controllera
    {
        return PlayerPrefs.GetFloat(volume);
    }

}
