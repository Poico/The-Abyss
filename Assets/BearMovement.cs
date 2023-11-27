using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearMovement : MonoBehaviour
{
    public AudioSource somPasso;
    public float speed=10f;
    Transform Player;
    public float minimumDistanceAttack=1f;
    public float minimumDistance=5;
    public float MaxDistance= 10f;
    public int damage=20;
    public float nextAttack;
    private float nextActionTime = 0.0f;
    public float period = 1f;
public bool A_Atacar=false;
    Animator anim;
    void Start()
    {
        somPasso = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
        anim.SetBool("Walking", true);
        Player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.transform.position.x<transform.position.x)
        {
            transform.rotation=Quaternion.Euler(0,0,0);
        }
        else
        {
            transform.rotation=Quaternion.Euler(0,180,0);
        }

        if (Vector2.Distance(transform.position, Player.position) < MaxDistance && A_Atacar==false)
        {
            transform.position= Vector2.MoveTowards(transform.position, Player.position, speed * Time.deltaTime);
            somPasso.Play();
            anim.SetBool("Walking", true);
            anim.SetBool("Slam", false);
        }
        if(Vector2.Distance(transform.position, Player.position)<= minimumDistanceAttack){
            if (Time.time > nextActionTime ) {
                A_Atacar=true;
                nextActionTime = Time.time+period;
                anim.SetBool("Walking", false);
                anim.SetBool("Slam", true);

            }
        }
    }
    void Attack(){
        if(Vector2.Distance(transform.position, Player.position)<= minimumDistanceAttack){
            Player.GetComponent<Life>().tirarVida(damage);
        }
        anim.SetBool("Walking", true);
        anim.SetBool("Slam", false);
        A_Atacar=false;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag=="Player")
        {
            Attack();

        }
    }
}
