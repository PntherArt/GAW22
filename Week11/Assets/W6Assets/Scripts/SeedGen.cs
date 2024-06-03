using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedGen : MonoBehaviour
{
    public string GameSeed = "Default";
    public int CurrentSeed = 0;

    public void Awake()
    {
        CurrentSeed = GameSeed.GetHashCode();
        Random.InitState(CurrentSeed);
    }

}

 

