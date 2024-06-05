using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatapadTrig : MonoBehaviour
{

    public GameObject datapad;
    public AudioSource snd;
   

    private void OnTriggerStay2D(Collider2D collision)
    {
        snd.Play();
        datapad.SetActive(true);
        
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            datapad.SetActive(false);


        }
    }
}
