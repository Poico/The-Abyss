using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile2 : MonoBehaviour
{
    Vector3 targetPosition;
    public float speed;
    void Start()
    {
        targetPosition = GameObject.FindGameObjectWithTag("Player").transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position= Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        if (transform.position== targetPosition)
        {
            Destroy(this.gameObject);
        }
    }
}
