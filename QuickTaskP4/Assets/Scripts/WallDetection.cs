using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDetection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            // Handle collision with a wall (e.g., stop the ball's movement or bounce it).
        }
    }

}
// This scipt I got it from an Ai source and how it works is when the ball hits aany wall it will detect say in the console. 