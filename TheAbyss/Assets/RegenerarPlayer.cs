using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegenerarPlayer : MonoBehaviour
{
    public Life vida;
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            vida.Regenerar(50);
            Destroy(this.gameObject);
        }
    }
}
