using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text winText; // Reference to the UI Text object for the win message
    public Transform player; // Reference to the player object
    private bool gameWon = false;
    private Vector3 initialPlayerPosition;

    void Start()
    {
        winText.gameObject.SetActive(false); // Hide the win text at the start
        initialPlayerPosition = player.position; // Store the initial position of the player
    }

    void Update()
    {
        if (gameWon && Input.GetKeyDown(KeyCode.R))
        {
            ResetGame();
            Time.timeScale = 1f; // Resume the game
        }
        CheckPlayerFall();
    }

    public void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Reload the current scene
        StartCoroutine(DeactivateSecondTextAfterDelay());
    }

    public void WinGame()
    {
        gameWon = true;
        winText.gameObject.SetActive(true); // Show the win text
        Time.timeScale = 0f; // Stop the game
    }

    // Deactivates the info text after 5 seconds
    private IEnumerator DeactivateSecondTextAfterDelay()
    {
        yield return new WaitForSeconds(5f);
    }

    private void CheckPlayerFall()
    {
        if (player.position.y < initialPlayerPosition.y - 15)
        {
            ResetGame();
        }
    }
}
