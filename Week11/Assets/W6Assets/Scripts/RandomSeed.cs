using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSeed : MonoBehaviour
{
    public string stringSeed = "seed string";
    public bool useStringSeed;
    public int seed;
    public bool randomSeed;

    private void Awake()
    {
        if (useStringSeed)
        {
            seed = stringSeed.GetHashCode();
        }

        if (randomSeed)
        {
            seed = Random.Range(0, 99);
        }

        Random.InitState(seed);

        print("The seed is " + seed);

    }



}
