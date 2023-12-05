using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor.Rendering;
using UnityEditor.Tilemaps;
using UnityEngine;

public class EnemyPatrolController : MonoBehaviour
{
    public Transform player;
    public Camera minimapCamera;
    public Button startButton;
    public Button restartButton;
    public GameObject welcomeScreen;
    public GameObject gameOverScreen;

    void Start()
    {
        startButton.onClick.AddListener(StartGame);
        restartButton.onClick.AddListener(RestartGame);

        // Show the welcome screen at the start
        ShowWelcomeScreen();
    }

    void LateUpdate()
    {
        // Your minimap update logic here
    }

    void StartGame()
    {
        welcomeScreen.SetActive(false);
        gameOverScreen.SetActive(false);
        // Add any additional logic to start your game
    }

    void RestartGame()
    {
        welcomeScreen.SetActive(false);
        gameOverScreen.SetActive(false);
        // Reset any game state or perform other restart logic
    }

    public void ShowWelcomeScreen()
    {
        welcomeScreen.SetActive(true);
        gameOverScreen.SetActive(false);
        // Add any additional logic when showing the welcome screen
    }

    public void ShowGameOverScreen()
    {
        welcomeScreen.SetActive(false);
        gameOverScreen.SetActive(true);
        // Add any additional logic when showing the game over screen
    }
}
