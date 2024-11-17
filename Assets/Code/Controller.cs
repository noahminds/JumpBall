using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float rollSpeed = 6.0f; // Speed at which the ball rolls
    public float jumpHeight = 8.0f; // Force applied for jumping
    private Rigidbody2D rb; // Reference to the Rigidbody2D component
    private float rollX;
    private bool jump = false; // Flag for jump input
    private bool isGrounded = false; // Checks if the ball is grounded
    private GameManager gameManager;
    private int groundContactCount = 0; // Number of ground objects in contact with the ball

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Get the Rigidbody2D component
        gameManager = FindObjectOfType<GameManager>(); // Find the GameManager in the scene
    }
    
    private void Update()
    {
        // Capture horizontal input
        rollX = Input.GetAxis("Horizontal") * rollSpeed;

        // Detect jump input
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
            groundContactCount++;
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            groundContactCount--;

            // If no more ground objects are in contact, the ball is no longer grounded
            if (groundContactCount <= 0)
            {
                isGrounded = false;
            }
        }
    }

    private void FixedUpdate()
    {
        // Update the position of the ball's rigidbody
        rb.position += new Vector2(rollX * Time.fixedDeltaTime, 0);

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

    // Check for collisions with spikes and the objective
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Spikes"))
        {
            // Disable gravity to prevent the ball from bouncing off the spikes
            rb.gravityScale = 0;
            rb.velocity = Vector2.zero; // Stop the ball's movement
            
            gameManager.ResetOnFail(); // Restart the level after a delay
        }
        else if (collision.CompareTag("Objective"))
        {
            gameManager.WinGame(); // Call the WinGame method when the player reaches the flag
        }
    }
}
