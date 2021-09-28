using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject mob;
    public Transform spawner;
    public float Timer = 2;

    // Update is called once per frame
    void Update()
    {

        Timer -= Time.deltaTime;
        if (Timer <= 0f)
        {
            Instantiate(mob, transform.position, transform.rotation);
            Timer = 3f;
        }

    }
    

    
}
