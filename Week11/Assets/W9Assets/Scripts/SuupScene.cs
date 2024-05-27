using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuupScene : MonoBehaviour
{
    public GameObject[] items;

    public GameObject[] canv;

    

    public static bool collected = false;
    private bool isTrig = false;

    private void Start()
    {
        
    }

    private void Update()
    {

        if (!items[0].activeInHierarchy && !items[1].activeInHierarchy && !items[2].activeInHierarchy && !items[3].activeInHierarchy && !items[4].activeInHierarchy)
        {
            collected = true;
            isTrig = false;
        }

        if (collected == true && isTrig == false)
        {
            canv[0].SetActive(false);
            canv[1].SetActive(true);
            isTrig = true;
        }
        
    }

    


}
