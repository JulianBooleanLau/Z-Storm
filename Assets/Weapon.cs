using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    public Transform firePoint;
    public GameObject bulletPrefab;
    public AudioSource gunshotSound;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot ()
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
}
