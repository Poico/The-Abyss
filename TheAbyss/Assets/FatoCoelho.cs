using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FatoCoelho : MonoBehaviour
{
    // Button
    public Button btnFatoCoelho;
    // bool variable
    public bool btnFatoCoelhoActive=false;
    private void Start() {
        btnFatoCoelho.gameObject.SetActive(false);
    }
    // Ontrigger
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            btnFatoCoelho.gameObject.SetActive(true);
            btnFatoCoelhoActive = true;
        }
    }

}
