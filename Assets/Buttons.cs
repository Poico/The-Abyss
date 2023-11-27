using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void Settings(){
        SceneManager.LoadScene("Settings");
    }
    public void Exit(){
        Application.Quit();
    }
    public void NewGame(){
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene(1);
    }
    public void LoadGame(){
        if (PlayerPrefs.GetInt("Level") == 0){
            SceneManager.LoadScene(1);
        }
        else{
            SceneManager.LoadScene(PlayerPrefs.GetInt("Level"));
        }
    }
}
