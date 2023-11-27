using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ColliderArma : MonoBehaviour
{
    [Header("Teste")]
    public int RetirarVida = 10;
    float timeStamp = 0;
    bool Click= false;
    private void KnockBack(Collider2D enemy)
    {
        Vector3 moveDirection = enemy.transform.position - this.transform.position;
        Debug.Log(moveDirection+enemy.name);
        enemy.GetComponent<Rigidbody2D>().AddForce( moveDirection.normalized * 5000f, ForceMode2D.Impulse);
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
        if (temp != null && timeStamp<=Time.time)
        {
            temp.tirarVida(RetirarVida);
            timeStamp = Time.time + 1f;
            
            KnockBack(other);
            Click=false;
        }
    }
}
