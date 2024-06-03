using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReelSnd : MonoBehaviour
{
    //This plays the sound for the reel
    public AudioSource snd;
    public void playReel()
    {
        snd.Play();
    }
}
