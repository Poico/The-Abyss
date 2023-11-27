using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CandyCounter : MonoBehaviour
{
    public Text Counter;
    void Start()
    {
        Counter.text= "0";
    }
    public void CandyAdd(){
        Counter.text= (int.Parse(Counter.text)+1).ToString();
    }
}
