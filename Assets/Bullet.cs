using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed = 20f;
    public int damage = 25;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed * Random.Range(0.6f, 1.4f);
    }

    void OnTriggerEnter2D (Collider2D hitInfo)
    {

        ObjectHealth objectHealth = hitInfo.GetComponent<ObjectHealth>();
        Debug.Log(hitInfo.GetComponent<ObjectHealth>());
        if (objectHealth != null)
        {
            objectHealth.TakeDamage(damage);
        }

        Destroy(gameObject);
    }

}
