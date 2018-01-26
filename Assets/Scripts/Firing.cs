using UnityEngine;
using System.Collections;

public class Firing : MonoBehaviour
{

    public GameObject projectile;
    private GameObject projectileParent;
    public GameObject shooter;

    void Start()
    {
        projectileParent = GameObject.Find("Projectiles");

        if(!projectileParent)
        {
            projectileParent = new GameObject();
        }
    }
    public void Fire()
    {
        GameObject newProjectile = Instantiate(projectile) as GameObject; // instancjonowanie nowych pocisków w animacji
        newProjectile.transform.parent = projectileParent.transform; // ustawia nowe projectile jako dzieci Projectiles
        newProjectile.transform.position = shooter.transform.position; //ustawia pozycje zespawnowanego pocisku na pozycje shootera
    }
}
