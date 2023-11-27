using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VidaNPC : MonoBehaviour
{
    public int VidaMaxima = 100;
    public GameObject CandyModel;
    public GameObject TokenModel;
    public GameObject VidaModel;
    public int vida;
    public int candyMax=6;
    public int candyMin=1;
    public bool Boss=false;

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
            int rand_num = rd.Next(candyMax,candyMin);
            for (int i = 0; i < rand_num; i++)
            {
                DropCandy();   
            }
            if (Boss==true)
            {
                DropToken();
                CenaSeguinte();
            }else
            {
                System.Random rd2 = new System.Random();
                if (rd2.Next(0,100)<=10)
                {
                    GameObject VidaModelDrop = Instantiate(VidaModel,transform.position,transform.rotation);
                }
            }
        }
    }
    void DropCandy(){
        Vector2 position = transform.position;
        position.x += Random.Range(-0.5f,0.5f);
        GameObject candy = Instantiate(CandyModel, position, Quaternion.identity);
    }
    void DropToken(){
        Vector2 position = transform.position;
        position.x += Random.Range(-0.5f,0.5f);
        GameObject Token = Instantiate(TokenModel, position, Quaternion.identity);
    }
    void CenaSeguinte(){
        Debug.Log("sim");
        SceneManager.LoadScene("Dialogo1");
    }

}
