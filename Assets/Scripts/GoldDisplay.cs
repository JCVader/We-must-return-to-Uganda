using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GoldDisplay : MonoBehaviour
{

    private Text text;
    int gold = 100;

    void Start()
    {
        text = GetComponent<Text>();
    }

    public void AddGold(int amount)
    {
        gold += amount;
        UpdateText();

    }

    public bool RemoveGold(int amount)
    {
        if (gold >= amount)
        {
            gold -= amount;
            UpdateText();
            return true;
        }
        else return false;
    }

    void UpdateText()
    {
        text.text = gold.ToString();
    }
}
