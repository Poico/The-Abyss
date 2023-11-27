using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
   public float bulletspeed=15f;
    public int bulletDamage=10;
    public Rigidbody2D rb;
    private void FixedUpdate() {
        rb.velocity=transform.right*bulletspeed;
    }
    private void OnTriggerEnter2D(Collider2D hitInfo) {
        VidaNPC vida=hitInfo.GetComponent<VidaNPC>();
        if(hitInfo.tag=="Enemy"){ 
            vida.tirarVida(bulletDamage);
        }
        Destroy(this.gameObject);
    }
}
