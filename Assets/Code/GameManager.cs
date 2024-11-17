using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text winText; // Reference to the UI Text object for the win message
    public Transform player; // Reference to the player object
    public AudioClip winClip; // Reference to the AudioClip for the win sound effect
    public AudioClip failClip; // Reference to the AudioClip for the fail sound effect
    private AudioSource audioSource; // Reference to the AudioSource component
    private bool gameWon = false;
    private Vector3 initialPlayerPosition;
    private bool resetting = false;

    void Start()
    {
        winText.gameObject.SetActive(false); // Hide the win text at the start
        initialPlayerPosition = player.position; // Store the initial position of the player
        audioSource = GetComponent<AudioSource>(); // Get the AudioSource component
    }

    void Update()
    {
        if (gameWon && Input.GetKeyDown(KeyCode.R))
        {
            ResetOnWin();
        }
        CheckPlayerFall();
    }

    private IEnumerator PlaySoundAndReset(AudioClip audioClip)
{
    audioSource.PlayOneShot(audioClip); // Play the fail sound effect
    yield return new WaitForSeconds(audioClip.length); // Wait for the sound effect to finish playing

    // Reset the scene after the sound has finished playing
    SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Reload the current scene

    // Unfreeze player movement
    player.GetComponent<Controller>().enabled = true;
}

    public void ResetOnFail()
    {
        if (!resetting) 
        {
             // Freeze player movement
            player.GetComponent<Controller>().enabled = false;

            // Start the coroutine to play the fail sound effect and reset the scene
            StartCoroutine(PlaySoundAndReset(failClip));

            resetting = true;
        }
    }

    public void ResetOnWin()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Reload the current scene
    }

    public void WinGame()
    {
        gameWon = true;
        winText.gameObject.SetActive(true); // Show the win text

        // Disable player movement
        player.GetComponent<Controller>().enabled = false;

        // Play the win sound effect
        audioSource.PlayOneShot(winClip);
    }

    private void CheckPlayerFall()
    {
        if (!resetting && player.position.y < initialPlayerPosition.y - 15)
        {
            ResetOnFail();
        }
    }
}
