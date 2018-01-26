using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{
    public float fadeInTime;
    private Image panel; 
    private Color colorChange = Color.black; // bierze kolor i przypisuje mu czarny

	void Start ()
    {
        panel = GetComponent<Image>(); // pobiera komponent image
	}
	
	void Update ()
    {
        if (Time.timeSinceLevelLoad < fadeInTime) // daje mu ifa z czasem wykonania żeby potem go wyłączyć
        {
            float change = Time.deltaTime / fadeInTime; //proporcja z jaką ma się zmieniać
            colorChange.a -= change; //odejmuje co klatkę zmianę w przeźroczystości
            panel.color = colorChange; // przypisuje ją do koloru
        }
        else
        {
            gameObject.SetActive(false); // wyłączam po upływie czasu
        }
        
       
	}
}
