using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowAi2 : MonoBehaviour
{
    public float speed=10f;
    public Transform Player;
    public float minimumDistance;
    public float MaxDistance= 10f;
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("Walking", false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, Player.position)> minimumDistance && Vector2.Distance(transform.position, Player.position) < MaxDistance)
        {
            transform.position= Vector2.MoveTowards(transform.position, Player.position, speed * Time.deltaTime);
            anim.SetBool("Walking", true);
        }
        else{
        Attack();
        }
    }
    public void Attack()
    {


    }
}
