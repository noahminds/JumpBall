using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    public float rollSpeed = 5.0f; // Speed at which the ball rolls
    public float jumpHeight = 15.0f; // Force applied for jumping
    public Rigidbody2D rb; // Rigidbody2D component of the ball

    private float rollX; // Horizontal input value for rolling
    private bool jump = false; // Flag for jump input
    private bool isGrounded = false; // Checks if the ball is grounded

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Get the Rigidbody2D component
    }
    
    private void Update()
    {
        // Capture horizontal input
        rollX = Input.GetAxis("Horizontal") * rollSpeed;

        // Detect jump input (only on the frame the space key is pressed)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump = true; // Set jump flag
        }
    }

    // Checks if the player is grounded
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            isGrounded = true; // Player is grounded
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            isGrounded = false; // Player is no longer grounded
        }
    }

    private void FixedUpdate()
    {
        // Move the ball horizontally
        rb.velocity = new Vector2(rollX, rb.velocity.y);

        // Rotate the ball to simulate rolling
        transform.Rotate(0, 0, -rollX * 1.5f);

        // Apply jump if the player is grounded
        if (jump && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
        }

        // Reset jump flag after processing
        jump = false;
    }
}
