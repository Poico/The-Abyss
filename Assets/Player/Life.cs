using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Life : MonoBehaviour
{
    public GameObject DeathMenuUI;
    public int VidaMaxima = 100;
    public int vida;
    public BarraDeVida healthbar;
    void Start() {
        
        DeathMenuUI=GameObject.FindGameObjectWithTag("DeathMenu");
        DeathMenuUI.SetActive(false);
        if (PlayerPrefs.HasKey("Vida"))
        {
            VidaMaxima=PlayerPrefs.GetInt("Vida");
        }else
        {
            PlayerPrefs.SetInt("Vida",VidaMaxima);
        }
 
        vida=VidaMaxima;
        healthbar = FindObjectOfType<BarraDeVida>();
        healthbar.SetMaxHealth(VidaMaxima);
    }
    public void tirarVida(int n)
    { 
        vida-=n;
        healthbar.SetHealth(vida);

    }
    public void Regenerar(int n)
    { 
        vida+=n;
        healthbar.SetHealth(vida);
    }
    public void AddLife(int n)
    { 
        vida+=n;
        VidaMaxima+=n;
        PlayerPrefs.SetInt("Vida",VidaMaxima);
        healthbar.SetMaxHealth(VidaMaxima);
        healthbar.SetHealth(vida);
    }
    void Update()
    {
        if (vida<=0 || this.gameObject.GetComponent<Transform>().position.y<=-10)
        {
            Destroy(this.gameObject);
            if (PlayerPrefs.HasKey("Mortes"))
            {
                PlayerPrefs.SetInt("Mortes",PlayerPrefs.GetInt("Mortes")+1);
            }else
            {
                PlayerPrefs.SetInt("Mortes",0);
            }
            DeathMenuUI.SetActive(true);
        }
    }
    public int GetVida()
    {
        return VidaMaxima;
    }
}
