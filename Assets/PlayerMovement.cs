using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //movement speed in units per second
    private float movementSpeed = 5f;

    void Update()
    {
        //Get the Input from Horizontal axis
        float horizontalInput = Input.GetAxis("Horizontal");
        //Get the Input from Vertical axis
        float verticalInput = Input.GetAxis("Vertical");


        //Update the position
        transform.position = transform.position + new Vector3(horizontalInput * movementSpeed * Time.deltaTime, verticalInput * movementSpeed * Time.deltaTime, 0);

        //Output to log the position change
        //Debug.Log(transform.position);
    }
}
