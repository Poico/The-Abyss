using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossCoelhoScript : MonoBehaviour
{
    Animator anim;
    public GameObject firingPoint;
    Vector2 posicaoInicial;
    Vector2 PosicaoSecundaria;
    Vector2 PosicaoRelativa;
    Vector2 Target;
    GameObject Player;
    bool primaria=true;
    
    void Start()
    {
        posicaoInicial=transform.position;
        PosicaoSecundaria=transform.position;
        PosicaoSecundaria.x-=10;
        Target=posicaoInicial;
        PosicaoRelativa=posicaoInicial;
        anim=GetComponent<Animator>();
    }

    void Movimento()
    {
        if(transform.position.y-Target.y<=0.5f && transform.position.y-Target.y>0.4f && primaria && Random.Range(0,1000)<=10)
        {
            transform.position=PosicaoSecundaria;
            PosicaoRelativa = PosicaoSecundaria;
            Target.x=PosicaoSecundaria.x;
            primaria=false;
        }
        if(transform.position.y-Target.y<=0.5f && transform.position.y-Target.y>0.4f && primaria==false && Random.Range(0,100)<=10)
        {
            transform.position=posicaoInicial;
            PosicaoRelativa = posicaoInicial;
            Target.x=posicaoInicial.x;
            primaria=true;
        }
    }
    void RotacaoBoss(){
        Player = GameObject.FindWithTag("Player");
        if (Player.transform.position.x<transform.position.x)
        {
            transform.rotation=Quaternion.Euler(0,180,0);
        }
        else
        {
            transform.rotation=Quaternion.Euler(0,0,0);
        }
    }
        
    void Update()
    {
        Movimento();
        RotacaoBoss();
    }
}
