using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    public Transform firePoint;
    public GameObject bulletPrefab;
    public AudioSource gunshotSound;
    public AudioSource reloadSound;
    public AudioSource emptySound;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && AmmoCountScript.currAmmo > 0)
        {
            Shoot();
            AmmoCountScript.currAmmo -= 1;
        } else if (Input.GetKeyDown("r"))
        {
            Reload();
        }
        
    }

    void Shoot()
    {
        gunshotSound.Play();
        //Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        
        int bulletCount = 3;
        float spread = Random.Range(0.1f, 4f);
        Quaternion newRot = firePoint.rotation;

        for (int i = 0; i < bulletCount; i++)
        {
            float addedOffset = (i - (bulletCount / 2) * spread);

            newRot = Quaternion.Euler(firePoint.eulerAngles.x, firePoint.eulerAngles.y, firePoint.eulerAngles.z + addedOffset);
            Instantiate(bulletPrefab, firePoint.position, newRot);
        }
    }

    //Works, but fix the logic
    void Reload()
    {

        if (!(AmmoCountScript.currAmmo == 2 || AmmoCountScript.maxAmmo == 0)) //Barrels not full / no ammo remaining
        {
            //Reload both barrels
            if (AmmoCountScript.maxAmmo == 1 || AmmoCountScript.currAmmo == 1) //Can only reload 1 shell
            {
                AmmoCountScript.currAmmo += 1;
                AmmoCountScript.maxAmmo -= 1;
            }
            else if (AmmoCountScript.currAmmo == 0)
            {

                AmmoCountScript.currAmmo += 2;
                AmmoCountScript.maxAmmo -= 2;
            }
            reloadSound.Play();
        }
        else
        {
            emptySound.Play();
        }
    }

}
