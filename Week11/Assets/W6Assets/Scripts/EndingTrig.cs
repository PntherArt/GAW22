using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingTrig : MonoBehaviour
{

    public GameObject canv;

    public void OnTriggerEnter(Collider other)
    {
        print("Ouch");
        canv.SetActive(true);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            print("quit");
        }
    }
}
