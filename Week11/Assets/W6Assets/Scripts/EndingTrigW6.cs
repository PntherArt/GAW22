using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingTrigW6 : MonoBehaviour
{
    //This triggers the end in zone 5
    public GameObject canv;

    //Turns the final canvas dialouge on
    public void OnTriggerEnter(Collider other)
    {
        print("Ouch");
        canv.SetActive(true);
    }

    //Allows the game to be quit
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            print("quit");
        }
    }
}
