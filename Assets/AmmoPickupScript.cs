using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickupScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Ammo picked up!" + col);

        if (col.gameObject != null && col.gameObject.tag == "Player")
        {
            AmmoCountScript.maxAmmo += 2;
            Destroy(gameObject);
        }

        
    }
}
