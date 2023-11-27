using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public void MainMenu(){
        Time.timeScale = 1f;
        GameIsPaused = false;
        SceneManager.LoadScene(0);
    }
    public void QuitGame(){
        PlayerPrefs.SetInt("Level",SceneManager.GetSceneByBuildIndex(1).buildIndex);
        Application.Quit();
    }
}
