using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMusic : MonoBehaviour
{
    public AudioSource bgaudio;
    void Start()
    {
        bgaudio.playOnAwake = true;
    }
}
