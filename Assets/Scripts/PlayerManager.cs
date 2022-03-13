using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    public static bool isGameOver;
    public static bool isPaused = false;
    public GameObject gameOverScreen;
    public GameObject PauseScreen;
    public GameObject VictoryScreen;
    private void Awake()
    {
        isGameOver = false;
    }
 
    void Update()
    {
        if (isGameOver)
        {
            gameOverScreen.SetActive(true);
        }
    }

    public void CompleteLevel()
    {
        VictoryScreen.SetActive(true);
    }
  
    public void Pause()
    {
        if(!isPaused)
        {
            PauseScreen.SetActive(true);
            Time.timeScale = 0f;
            isPaused = true;
        }
        else
        {
            PauseScreen.SetActive(false);
            Time.timeScale = 1f;
            isPaused = false;
        }
    }
    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Menu()
    {
        isPaused = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
