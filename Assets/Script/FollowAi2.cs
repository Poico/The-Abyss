using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowAi2 : MonoBehaviour
{
    public AudioSource somPasso;
    public float speed=10f;
    Transform Player;
    public float minimumDistance;
    public float MaxDistance= 10f;
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("Walking", false);
        DelayedStart();
    }
    void DelayedStart(){
        Player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(Player == null)
        {
            Debug.Log("Player não encontrado"+this.gameObject.name);
            DelayedStart();
        }
        if (Player.transform.position.x<transform.position.x)
        {
            transform.rotation=Quaternion.Euler(0,180,0);
        }
        else
        {
            transform.rotation=Quaternion.Euler(0,0,0);
        }
        
        if (Vector2.Distance(transform.position, Player.position)> minimumDistance && Vector2.Distance(transform.position, Player.position) < MaxDistance)
        {
            somPasso.Play();
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
