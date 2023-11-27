using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ColliderArma : MonoBehaviour
{
    [Header("Teste")]
    AudioSource audioSource;
    public int RetirarVida = 10;
    float timeStamp = 0;
    bool Click= false;
    Animator anim;
    private void Start() {
        anim = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        if (PlayerPrefs.GetInt("Dano")==0)
        {
            PlayerPrefs.SetInt("Dano",10);
        }else
        {
            RetirarVida=PlayerPrefs.GetInt("Dano");
        }
    }
    private void KnockBack(Collider2D enemy)
    {
        Vector3 moveDirection = enemy.transform.position - this.transform.position;
        enemy.GetComponent<Rigidbody2D>().AddForce( moveDirection.normalized * 5f, ForceMode2D.Impulse);
    }
    public void Attack(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            audioSource.PlayDelayed(1);
            Click = true;
            anim.SetTrigger("Tesoura");
        }
    }
    public void AddAttack(int n){
        RetirarVida+=n;
        PlayerPrefs.SetInt("Dano",RetirarVida);
    }
    private void OnTriggerStay2D(Collider2D other) {
        if (other.gameObject.tag=="Enemy" && Click)
        {
            Debug.Log("Vida");
            TakeLife(other);
            Click= false;
        }
    }
    private void TakeLife(Collider2D other)
    {
        var temp = other.transform.GetComponent<VidaNPC>() as VidaNPC;
        if (temp != null && timeStamp<=Time.time)
        {
            temp.tirarVida(RetirarVida);
            timeStamp = Time.time + 1f;
            KnockBack(other);
            Click=false;
        }
    }
    public int GetAttack(){
        return RetirarVida;
    }
}
