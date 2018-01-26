using UnityEngine;
using System.Collections;

public class DefenderPlacer : MonoBehaviour
{
    public Camera myCamera;
    GoldDisplay goldDisplay;

    void Start()
    {
        goldDisplay = FindObjectOfType<GoldDisplay>();
    }

    void OnMouseDown() // tu się magia działa 
    {
        Vector2 position = WorldPosition();
        GameObject defender = Placer.selected;
        int cost = defender.GetComponent<Defender>().goldCost;
        if (goldDisplay.RemoveGold(cost) == true)
        {
            Instantiate(Placer.selected, position, Quaternion.identity);
        }
        else Debug.Log("Not enough gold");
    }

    Vector2 WorldPosition()
    {
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
        float xPosition = Mathf.RoundToInt(worldPos.x);
        float yPosition = Mathf.RoundToInt(worldPos.y);

        return new Vector2(xPosition + 4.5f, yPosition + 3.7f);

    }
}
