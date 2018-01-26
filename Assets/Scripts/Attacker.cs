using UnityEngine;
using System.Collections;

public class Attacker : MonoBehaviour
{
     private float currentSpeed; // szybkosc chodzenia atakujacych
     private GameObject currentTarget;
     private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }
	
	void Update ()
    {
        transform.Translate(Vector3.left * currentSpeed * Time.deltaTime); // przeciwnicy ida w lewo z dana szybkoscia
        if (!currentTarget) //jeśli nie ma targetu w colliderze to wyłącza animacje ataku
        {
            animator.SetBool("isAttacking", false);
        }

	}

    public void SetSpeed(float speed) // szybkosc ustawiania w animacji
    {
        currentSpeed = speed;
    }

    public void AttackTarget (float damage) // w animacji jest ustwiony w połowie float z wartością zadawanego dmg
    {
        if (currentTarget) // jeśli jest currentTarget
        {
            Health HP = currentTarget.GetComponent<Health>(); // przypisuje zmiennej HP w klasie Health ilość życia currentTargetu
            if (HP) // jeśli currentTarget ma komponent HP
            {
                HP.DealDamage(damage); // to zadaje mu dmg
            }
        }

    }
    //Pobiera informacje z klasy Lizard
    public void Attack (GameObject obj)
    {
        currentTarget = obj; //daje znać klasie Attacker, że w colliderze Lizarda znalazł się obiekt, który jest defenderem i przypisuje go do currentTarget
    }
}
