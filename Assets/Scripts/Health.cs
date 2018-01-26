using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour
{
    public float HP;

    public void DealDamage(float damage)
    {
            HP -= damage;
        if(HP <= 0)
        {
            DestroyObject(gameObject); // jak hp spadnie do 0 to niszczy obiekt
        }
    }
}
