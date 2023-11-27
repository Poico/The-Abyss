using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIShootRetreat2 : MonoBehaviour
{
    public float speed=10f;
    public Transform Player;
    public float minimumDistance;

    public GameObject projectile;
    public float timeBetweenShots;
    private float nextShotTime;
    void Update()
    {
        if (Time.time > nextShotTime)
        {
            Instantiate(projectile, transform.position,Quaternion.identity);
            nextShotTime = Time.time+ timeBetweenShots;
        }
        if (Vector2.Distance(transform.position, Player.position) < minimumDistance)
        {
            transform.position= Vector2.MoveTowards(transform.position, Player.position, -speed * Time.deltaTime);    
        }else{
            Attack();
        }
    }
    public void Attack()
    {

        
    }
}
