using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class VidaShop : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Vida")]
    public TMP_Text TextVida;
    [SerializeField] Life vida;
    [SerializeField] int vidaAdd=10;
    [SerializeField] int vidaPrice=10;
    [SerializeField] int vidaPriceAdd=10;
    [Header("Dano")]
    public TMP_Text TextDano;
    ColliderArma arma;
    [SerializeField] int danoAdd=10;
    [SerializeField] int danoPrice=10;
    [SerializeField] int danoPriceAdd=10;
    void Start () {
        //DelayedStart();
	}
	void DelayedStart(){
        if (PlayerPrefs.GetInt("Vida")==0)
        {
            PlayerPrefs.SetInt("Vida",100);
        }
        if(PlayerPrefs.GetInt("Dano")==0)
        {
            PlayerPrefs.SetInt("Dano",10);
        }
        TextDano.text = "Dano: "+PlayerPrefs.GetInt("Dano").ToString();
        TextVida.text = "Vida: "+PlayerPrefs.GetInt("Vida").ToString();
    }
    private void Update() {
        if (arma == null || vida == null)
        {
            DelayedStart();
        }
    }
    public void AdicionarVida(){
        if (vidaPrice<=PlayerPrefs.GetInt("Coins")){
            PlayerPrefs.SetInt("Vida",PlayerPrefs.GetInt("Vida")+vidaAdd);
            PlayerPrefs.SetInt("Coins",PlayerPrefs.GetInt("Coins")-vidaPrice);
            vidaPrice+=vidaPriceAdd;
        }
    }
    public void AdicionarDano(){
        if (danoPrice<=PlayerPrefs.GetInt("Coins")){
            PlayerPrefs.SetInt("Dano",PlayerPrefs.GetInt("Dano")+danoAdd);
            PlayerPrefs.SetInt("Coins",PlayerPrefs.GetInt("Coins")-danoPrice);
            danoPrice+=danoPriceAdd;
        }
    }
}
