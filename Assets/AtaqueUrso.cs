using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AtaqueUrso : MonoBehaviour
{
    
    int RetirarVida = 10;
    public GameObject Arma;
    bool Click;
    
    private void Start() {
        // get tag Arma 
        Arma = GameObject.FindWithTag("Arma");
        
    }
     public void Attack(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Click = true;
        }
    }
    private void OnTriggerStay2D(Collider2D other) {
        if (other.gameObject.tag=="Enemy" && Click)
        {
            TakeLife(other);
            Click= false;
        }
    }
    private void TakeLife(Collider2D other)
    {
        var temp = other.transform.GetComponent<VidaNPC>() as VidaNPC;
        if (temp != null)
        {
            temp.tirarVida(RetirarVida);
            Click=false;
        }
    }
}
