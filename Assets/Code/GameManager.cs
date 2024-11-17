using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text winText; // Reference to the UI Text object for the win message
    private bool gameWon = false;

    void Start()
    {
        winText.gameObject.SetActive(false); // Hide the win text at the start
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || gameWon && Input.GetKeyDown(KeyCode.R))
        {
            ResetGame();
            Time.timeScale = 1f; // Resume the game
        }
    }

    public void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Reload the current scene
    }

    public void WinGame()
    {
        gameWon = true;
        winText.gameObject.SetActive(true); // Show the win text
        Time.timeScale = 0f; // Stop the game
    }
}
