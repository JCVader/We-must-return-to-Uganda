using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour
{
    public float speed;
    public float damage;

	void Update ()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime); // parametry pocisku
	}

    void OnTriggerEnter2D(Collider2D collider)
    {
        Attacker attacker = collider.gameObject.GetComponent<Attacker>(); // jeśli obiekt jest attackerem i wejdzie w collider projectila
        Health HP = collider.gameObject.GetComponent<Health>(); // bierze jego HP

        if (attacker && HP) // jeśli jest attackerem i ma HP
        {
            HP.DealDamage(damage); // zadaje mu dmg uwzględniony w animacji
            Destroy(gameObject); // niszczy ten projectile po kolizji
        }
    }
}
