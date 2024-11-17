using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float moveSpeed = 2f; // Speed of the platform movement
    public int startingPos; // Starting position of the platform
    public Transform[] range; // Array of positions for the platform to move between
    private int i; // Index of the current position
    private Rigidbody2D rb;

    void Start()
    {
        transform.position = range[startingPos].position;
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // If the platform is at the target point, move to the next point
        if (Vector2.Distance(transform.position, range[i].position) < 0.01f)
        {
            i = (i + 1) % range.Length;
        }
    }

    void FixedUpdate()
    {
        // Move the platform towards the next position
        Vector2 newPosition = Vector2.MoveTowards(rb.position, range[i].position, moveSpeed * Time.fixedDeltaTime);
        rb.MovePosition(newPosition);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // If the player collides with the platform, make the player a child of the platform's parent (used to preserve scale)
        if (collision.collider.CompareTag("Player"))
        {
            collision.transform.SetParent(transform.parent);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        // If the player leaves the platform, remove the parent-child relationship
        if (collision.collider.CompareTag("Player"))
        {
            collision.transform.SetParent(null);
        }
    }
}
