using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingSwitches : MonoBehaviour
{
    public GameObject[] button;

    public GameObject[] canv;

    public GameObject btn;

    public AudioSource[] snd;

    public string level;

    private void Update()
    {
        if (canv[0].activeInHierarchy)
        {
            Invoke("BtnIn", 2f);
        }

        if (canv[1].activeInHierarchy)
        {
            Invoke("BtnHome", 2f);
        }

        if (canv[2].activeInHierarchy)
        {
            Invoke("BtnLetter", 2f);
        }


    }

    void BtnIn()
    {
        button[0].SetActive(true);
    }

    void BtnHome()
    {
        button[0].SetActive(false);
        button[1].SetActive(true);
    }

    void BtnLetter()
    {
        button[1].SetActive(false);
        button[2].SetActive(true);
    }


    public void enter()
    {
        button[0].SetActive(false);
        canv[0].SetActive(false);
        snd[0].Play();
        canv[1].SetActive(true);
        
    }

    public void home()
    {
        snd[1].Play();
        button[1].SetActive(false);
        canv[1].SetActive(false);
        
        canv[2].SetActive(true);
        
    }

    public void end()
    {
        SceneManager.LoadScene(level);
    }

}
