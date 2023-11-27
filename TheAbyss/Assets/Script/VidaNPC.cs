using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaNPC : MonoBehaviour
{
     public int VidaMaxima = 100;
     public GameObject CandyModel;
    public int vida;
    void Start() {
        vida=VidaMaxima;
    }
    public void tirarVida(int n)
    { 
        vida-=n;
    }
    void Update()
    {
        if (vida<=0)
        {
            Destroy(this.gameObject);
            System.Random rd = new System.Random();
            int rand_num = rd.Next(1,6);
            for (int i = 0; i < rand_num; i++)
            {
                DropCandy();   
            }
        }
    }
    void DropCandy(){
        Vector2 position = transform.position;
        GameObject candy = Instantiate(CandyModel, position, Quaternion.identity);
    }
}
