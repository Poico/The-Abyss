using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class ShopScript : MonoBehaviour
{
    public Life life = new Life();
    public Slider healthSlider;
    public int maxHealth;
    public Text CandyCounter;
    public int currentHealth;

    public Slider SliderMaxUp;
    public Slider SliderMaxUp2;
    void Start()
    {
        setVars();
        SliderMaxUp.minValue=0;
        SliderMaxUp.value=0;
        SliderMaxUp.maxValue=10;

        SliderMaxUp2.minValue=0;
        SliderMaxUp2.value=0;
        SliderMaxUp2.maxValue=10;
    }

    void setVars()
    {
        currentHealth = life.vida;
        maxHealth = life.VidaMaxima;
    }
    public void buyHealth(){
        Debug.Log("Botão Pressionado");
        if (currentHealth< maxHealth && Convert.ToInt32(CandyCounter.text)>20 && SliderMaxUp.value<10)
        {
            life.VidaMaxima+=10;
            life.vida +=10;
            SliderMaxUp.value+=1;
            CandyCounter.text= (Convert.ToInt32(CandyCounter.text)-20).ToString();
            Debug.Log("Vida adicionada");
        }else
        {
            Debug.Log("Max Health");
        }
    }
}
