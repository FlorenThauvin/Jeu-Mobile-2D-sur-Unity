using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject settingsWindow;
    public GameObject levelWindow;

    public void ButtonStart(string level) 
    {
        Debug.Log("test");
        SceneManager.LoadScene(level);
    }

    public void SettingsButton()
    {
        settingsWindow.SetActive(true);
    }

    public void CloseSettingsWindow()
    {
        settingsWindow.SetActive(false);
    }

    public void LevelButton()
    {
        levelWindow.SetActive(true);
    }

    public void CloseLevelWindow()
    {
        levelWindow.SetActive(false);
    }

    public void ButtonQuit()
    {
        Application.Quit();
    }

}
