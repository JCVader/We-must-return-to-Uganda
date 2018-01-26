using UnityEngine;
using System.Collections;

public class Defender : MonoBehaviour
{

    public int goldCost = 30;
    private GoldDisplay goldDisplay;

    void Start()
    {
        goldDisplay = FindObjectOfType<GoldDisplay>();
    }
    public void AddStars (int amount)
    {
        goldDisplay.AddGold(amount);
    }


}
