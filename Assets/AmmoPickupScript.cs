using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickupScript : MonoBehaviour
{
    public AudioSource pickupSound;

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Ammo picked up!" + col);

        if (col.gameObject != null && col.gameObject.tag == "Player")
        {
            pickupSound.Play();
            AmmoCountScript.maxAmmo += 2;
            Destroy(gameObject);
        }
    }
}
