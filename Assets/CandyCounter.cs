using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CandyCounter : MonoBehaviour
{
    public Text Counter;
    void Start()
    {
        Counter.text= PlayerPrefs.GetInt("Coins").ToString();
    }
    public void CandyAdd(){
        Counter.text= (int.Parse(Counter.text)+1).ToString();
        PlayerPrefs.SetInt("Coins",PlayerPrefs.GetInt("Coins")+1);
    }
    private void Update() {
        Counter.text= PlayerPrefs.GetInt("Coins").ToString();
    }
}
