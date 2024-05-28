using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour
{
    //This script handles both the input and cameras for week 1's minigame 2
    public GameObject[] cams;
    public GameObject[] lettersPop;
    public AudioSource jmpSnd;

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.S))
        {
            cams[0].SetActive(false);
            cams[1].SetActive(true);
            jmpSnd.Play();
            lettersPop[0].SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            cams[1].SetActive(false);
            cams[2].SetActive(true);
            jmpSnd.Play();
            lettersPop[1].SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            cams[2].SetActive(false);
            cams[3].SetActive(true);
            jmpSnd.Play();
            lettersPop[2].SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.U))
        {
            cams[3].SetActive(false);
            cams[4].SetActive(true);
            jmpSnd.Play();
            lettersPop[3].SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            cams[4].SetActive(false);
            cams[5].SetActive(true);
            jmpSnd.Play();
            lettersPop[4].SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            cams[5].SetActive(false);
            cams[6].SetActive(true);
            jmpSnd.Play();
            lettersPop[5].SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            cams[6].SetActive(false);
            cams[7].SetActive(true);
            jmpSnd.Play();

        }

    }
}
