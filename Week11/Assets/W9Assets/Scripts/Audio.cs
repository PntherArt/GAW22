using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioSource snd;

    public void playAudio()
    {
        snd.Play();
    }
}
