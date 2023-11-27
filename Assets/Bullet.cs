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
        if (hitInfo.gameObject.tag=="Player")
        {
            hitInfo.GetComponent<Life>().tirarVida(10);
            Destroy(this);
        }
        if (hitInfo.gameObject.tag=="Enemy")
        {
            hitInfo.GetComponent<VidaNPC>().tirarVida(10);
            Destroy(this);
        }
    }
    void Start()
    {
        StartCoroutine(SelfDestruct());
    }
    
    IEnumerator SelfDestruct()
    {
     yield return new WaitForSeconds(5f);
     Destroy(gameObject);
    }
}
