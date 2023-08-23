using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5.0f; // Adjust this value to set the movement speed.

    void Update()
    {
        // Get input from arrow keys or WASD.
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate the movement direction.
        Vector3 movement = new Vector3(horizontalInput, 0.0f, verticalInput);

        // Normalize the movement vector to ensure consistent speed regardless of direction.
        movement.Normalize();

        // Move the object based on input and speed.
        transform.Translate(movement * moveSpeed * Time.deltaTime);
    }
}
// // This scipt I got it from an Ai source  and makes the ball move. 