using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projetil2D : MonoBehaviour
{
  public float fireRate = 0.2f;
  public Transform firingPoint;
  public GameObject bulletPrefab;
  float timeToFire = 0;
  public void Fire() {
    if (Time.time > timeToFire) {
      timeToFire = Time.time + 1 / fireRate;
      GameObject bullet = Instantiate(bulletPrefab, firingPoint.position, firingPoint.rotation);
    }
  }
}
