using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{

    public float spawnRate;
    public GameObject spawners;
	
	void Update ()
    {
	    if(isTimeToSpawn (spawners))
        {
            Spawn(spawners);
        }
	}

    void Spawn (GameObject lizard)
    {
        GameObject attacker = Instantiate(lizard) as GameObject; // tworze attackera z prefaba
        attacker.transform.parent = transform; // tak jak wcześniej daje mu parenta
        attacker.transform.position = transform.position; // ustawiam zepsuty transform...
    }
    bool isTimeToSpawn(GameObject lizard)
    {
        
        float time = Time.deltaTime * spawnRate / 10;
        if (Random.value < time)
        {
            return true;
        }
        else return false;
    }
}
