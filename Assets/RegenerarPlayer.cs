using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegenerarPlayer : MonoBehaviour
{

    public Life vida;
    private void Update() {
        if(vida == null){
            vida = GameObject.FindGameObjectWithTag("Player").GetComponent<Life>();
        }
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            vida.Regenerar(50);
            Destroy(this.gameObject);
        }
    }
}
