using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuTemp : MonoBehaviour
{
    GameObject pauseMenuUI;
    public bool GameIsPaused = false;
    private void Awake() {
        pauseMenuUI=GameObject.FindGameObjectWithTag("PauseMenu");
        pauseMenuUI.SetActive(false);
    }

    public void Esc()
    {
        if (GameIsPaused)
        {
            Resume();
        }
        else
        {
            Pause();
        }

    }

    void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}
