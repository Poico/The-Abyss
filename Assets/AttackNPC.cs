using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackNPC : MonoBehaviour
{
    [SerializeField] private int AttackDamage = 20;
    [SerializeField] private float attackSpeed = 1f;
    private float canAttack;
    private void OnTriggerStay2D(Collider2D other) {
        if (other.gameObject.tag=="Player")
        {
            if (attackSpeed <= canAttack)
            {
                TakeLife(other);
                canAttack=0f;   
            }else
            {
                canAttack+=Time.deltaTime;
            }
        }
    }
    private void TakeLife(Collider2D other)
    {
        var temp = other.transform.GetComponent<Life>() as Life;
        if (temp != null)
        {
            temp.tirarVida(AttackDamage);
        }
    }
}
