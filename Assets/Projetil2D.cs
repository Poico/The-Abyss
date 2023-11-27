using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projetil2D : MonoBehaviour
{
  AudioSource Spit;
  public float fireRate = 0.2f;
  public Transform firingPoint;
  public GameObject bulletPrefab;
  public float period = 1f;
  private void Start() {
    Spit = GetComponent<AudioSource>();
  }
  public void Disparar() {
    Spit.Play();
    GameObject bullet = Instantiate(bulletPrefab, firingPoint.position, firingPoint.rotation);
    
  }
}
