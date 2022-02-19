using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public HealthBar healthBar;
    public int maxHealth = 50;
    public int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    //Player damage
    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Damage taken" + col);

        if (col.gameObject != null && col.gameObject.tag == "Zombie")
        {
            //pickupSound.Play();
            TakeDamage(20);
        }
    }

    //movement speed in units per second
    private float movementSpeed = 5f;

    void Update()
    {
        /*
         * Movement of the player.
         */

        //Get the Input from Horizontal axis
        float horizontalInput = Input.GetAxis("Horizontal");
        //Get the Input from Vertical axis
        float verticalInput = Input.GetAxis("Vertical");


        //Update the position
        transform.position = transform.position + new Vector3(horizontalInput * movementSpeed * Time.deltaTime, verticalInput * movementSpeed * Time.deltaTime, 0);

        //Output to log the position change
        //Debug.Log(transform.position);

        /* 
         * Rotation of the player
         */

        //Get the Screen positions of the object
        Vector2 positionOnScreen = Camera.main.WorldToViewportPoint(transform.position);

        //Get the Screen position of the mouse
        Vector2 mouseOnScreen = (Vector2)Camera.main.ScreenToViewportPoint(Input.mousePosition);

        //Get the angle between the points
        float angle = AngleBetweenTwoPoints(positionOnScreen, mouseOnScreen);

        //Ta Daaa
        transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, angle));
    }

    float AngleBetweenTwoPoints(Vector3 a, Vector3 b)
    {
        return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
    }
}
