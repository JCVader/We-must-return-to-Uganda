using UnityEngine;
using System.Collections;

public class Lizard : MonoBehaviour
{
    private Animator animator; 
    private Attacker attacker; 

    void Start()
    {
        animator = GetComponent<Animator>(); // pobiera animator obiektu
        attacker = GetComponent<Attacker>(); // pobiera skrypt Attacker komponentu
    }
    void OnTriggerEnter2D (Collider2D collider)
    {
        GameObject obj = collider.gameObject; // po wejściu w collider pobiera game object w który weszedł

        if (obj.GetComponent<Defender>()) // jak jest defenderem
        {
            animator.SetBool("isAttacking", true); // włącza lizardowi animacje ataku
            attacker.Attack(obj); //wysyła do metody Attack w klasie Attacker informacje o atakowanym obiekcie
        }
        else return;
    }
}
