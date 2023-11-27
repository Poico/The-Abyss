using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candy : MonoBehaviour
{
    public CandyCounter Counter;
    void Start()
    {
        Counter = GameObject.FindGameObjectsWithTag("Counter")[0].GetComponent<CandyCounter>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Counter.CandyAdd();
            Destroy(this.gameObject);
        }
    }
}
