using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void ChangeToScene(int sceneToChangeTo){
        SceneManager.LoadScene(sceneToChangeTo);
    }
    public void Exit(){
        Application.Quit();
    }
}
