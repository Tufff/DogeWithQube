using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    bool IsGamePaused = false;

    public GameObject pauseMenu;
    GameManager gameManager;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!gameManager.gameOver)
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
