using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HabilidadesPlayer : MonoBehaviour
{
    
    public GameObject Cenoura;
    public GameObject firingpoint;
    private float timeStamp;
    private float timeStamp2;
    public float coolDownPeriodInSeconds = 10f;

    public void DispararCenoura()
    {
        timeStamp = Time.time + coolDownPeriodInSeconds;
        if (timeStamp <= Time.time && PlayerPrefs.GetInt("Cenoura") == 1)
        {
            Instantiate(Cenoura, firingpoint.transform.position, firingpoint.transform.rotation);
        }
    }
    public void AtaqueMaior(){
        timeStamp2 = Time.time + coolDownPeriodInSeconds;
        if (timeStamp2 <= Time.time)
        {
            Debug.Log("Ataque Urso");
        }
    } 

}
