using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Create public variables for player speed, and for the Text UI game objects
    public float speed;
    // Create private references to the rigidbody component on the player, and the count of pick up objects picked up so far
    private Rigidbody rb;
    private int count;

    // At the start of the game..
    void Start()
    {
        // Assign the Rigidbody component to our private rb variable
        rb = GetComponent<Rigidbody>();
    }

    // Each physics step..
    void FixedUpdate()
    {
        // Set some local float variables equal to the value of our Horizontal and Vertical Inputs
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // Create a Vector3 variable, and assign X and Z to feature our horizontal and vertical float variables above
        Vector3 movement = new Vector3(h, 0.0f, v);

        // Add a physical force to our Player rigidbody using our 'movement' Vector3 above, 
        // multiplying it by 'speed' - our public player speed that appears in the inspector
        rb.AddForce(movement * speed);
    }

}
