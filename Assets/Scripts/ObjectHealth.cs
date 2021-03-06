using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHealth : MonoBehaviour
{

    public int health = 100;
    public GameObject deathEffect;

    public void TakeDamage (int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    void Die ()
    {
        Destroy(gameObject);
        if (gameObject.tag == "Zombie")
        {
            KillCounter.numKills += 1;
        }
    }
    
}
