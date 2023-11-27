using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public Slider slider;
    public void ChangeVolume(){
        AudioListener.volume = slider.value;
    }
    public void ChangeToScene(){
        SceneManager.LoadScene(0);
    }
}
