using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    //This script handles all of the scene switching in the game
    [Header("Scene Switcher")]
    public GameObject[] GameCanv;
    public GameObject[] supOut;
    private bool invokeD = false;
    public string level;
    public AudioSource snd;

    [Header("Ending Switcher")]
    public GameObject[] button;
    public GameObject[] canv;
    public GameObject btn;
    public AudioSource[] snd1;
    public string levelEnd;


    private void Update()
    {
        //These handle the switches between the scenes before the final scene
        if (GameCanv[2].activeInHierarchy && invokeD == false)
        {
            Invoke("btnUp", 2f);
            invokeD = true;
        }

        if (supOut[2].activeInHierarchy)
        {
            supOut[0].SetActive(false);
        }

        //These handle the ending scene of week9 game
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

    //This handles the supermarket section of the game
    public void LetsGo()
    {
        GameCanv[0].SetActive(false);
        GameCanv[1].SetActive(false);
        GameCanv[2].SetActive(true);
    }

    public void btnUp()
    {
        supOut[0].SetActive(true);
    }

    public void InsideSuup()
    {
        snd.Play();
        Invoke("next", 5f);
    }

    //this loads the back home scene
    public void next()
    {
        SceneManager.LoadScene(level);
    }

    //This handles the final home packaging, post office and recieving box sequence
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
        snd1[0].Play();
        canv[1].SetActive(true);

    }

    public void home()
    {
        snd1[1].Play();
        button[1].SetActive(false);
        canv[1].SetActive(false);

        canv[2].SetActive(true);

    }
    //this loads the scene with the letter
    public void end()
    {
        SceneManager.LoadScene(levelEnd);
    }
}
