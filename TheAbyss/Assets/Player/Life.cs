using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    public int VidaMaxima = 100;
    public int vida;
    public BarraDeVida healthbar;
    void Start() {
        vida=VidaMaxima;
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
    void Update()
    {
        if (vida<=0)
        {
            Destroy(this.gameObject);
        }
    }
}
