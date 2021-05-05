using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    bool IsGamePaused = false;

    public GameObject pauseMenu;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (IsGamePaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        Time.timeScale = 1f;
        IsGamePaused = false;
        pauseMenu.SetActive(false);
    }

    void Pause()
    {
        Time.timeScale = 0f;
        IsGamePaused = true;
        pauseMenu.SetActive(true);
    }
}
