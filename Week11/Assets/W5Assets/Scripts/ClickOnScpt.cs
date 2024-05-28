using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClickOnScpt : MonoBehaviour
{
    //This handles all of the timings of the canvas changes and inputs
    public GameObject trigBlock;
    public GameObject[] clickCanvas;
    public GameObject camObj;
    public GameObject[] PCscrImg;
    public GameObject gameMan;
    int currentIndex = 0;
    public AudioSource emailSnd;
    public AudioClip[] sndClick;
    public AudioSource randmSnd;
    public AudioSource phoneSnd;
    public GameObject[] phoneCalloBj;
    public Animator anim;
    public string trigName;
    public GameObject animCanv;

    public void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            camObj.GetComponent<CameraScript>().speed = 0;
            randmSnd.clip = sndClick[Random.Range(0, sndClick.Length)];
            randmSnd.Play();

            clickCanvas[currentIndex].SetActive(true);
            trigBlock.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
        }

    }

    public void Update()
    {

        if (Input.GetMouseButtonDown(1))
        {
            camObj.GetComponent<CameraScript>().speed = 3;

            foreach (var obj in clickCanvas)
            {
                obj.SetActive(false);
            }
            trigBlock.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
        }

        if(gameMan.GetComponent<GameManager>().timeTaken >= 40 && gameMan.GetComponent<GameManager>().timeTaken <= 42)
        {
           
            PCscrImg[0].SetActive(false);
            PCscrImg[1].SetActive(true);
            currentIndex = 6;
            emailSnd.Play();
            
        }

        if (gameMan.GetComponent<GameManager>().timeTaken >= 70 && gameMan.GetComponent<GameManager>().timeTaken <= 72)
        {
            currentIndex = 7;
            emailSnd.Play();

        }

        if (gameMan.GetComponent<GameManager>().timeTaken >= 100 && gameMan.GetComponent<GameManager>().timeTaken <= 102)
        {

            currentIndex = 8;
            emailSnd.Play();

        }

        if (gameMan.GetComponent<GameManager>().timeTaken >= 115 && gameMan.GetComponent<GameManager>().timeTaken <= 117)
        {

            currentIndex = 4;
            PCscrImg[1].SetActive(false);
            PCscrImg[0].SetActive(true);
            emailSnd.Play();

        }

        if (gameMan.GetComponent<GameManager>().timeTaken >= 140 && gameMan.GetComponent<GameManager>().timeTaken <= 142)
        {

            currentIndex = 9;
            PCscrImg[0].SetActive(false);
            PCscrImg[1].SetActive(true);
            emailSnd.Play();

        }

        if (gameMan.GetComponent<GameManager>().timeTaken >= 170 && gameMan.GetComponent<GameManager>().timeTaken <= 172)
        {

            currentIndex = 4;
            PCscrImg[1].SetActive(false);
            PCscrImg[0].SetActive(true);
            emailSnd.Play();

        }

        if (gameMan.GetComponent<GameManager>().timeTaken >= 200 && gameMan.GetComponent<GameManager>().timeTaken <= 202)
        {

            currentIndex = 10;
            PCscrImg[0].SetActive(false);
            PCscrImg[1].SetActive(true);
            emailSnd.Play();

        }

        if (gameMan.GetComponent<GameManager>().timeTaken >= 215 && gameMan.GetComponent<GameManager>().timeTaken <= 217)
        {

            currentIndex = 11;
            emailSnd.Play();

        }

        if (gameMan.GetComponent<GameManager>().timeTaken >= 240 && gameMan.GetComponent<GameManager>().timeTaken <= 242)
        {

            currentIndex = 4;
            PCscrImg[1].SetActive(false);
            PCscrImg[0].SetActive(true);
            emailSnd.Play();

        }

        if (gameMan.GetComponent<GameManager>().timeTaken >= 270 && gameMan.GetComponent<GameManager>().timeTaken <= 272)
        {

            currentIndex = 13;
            emailSnd.Play();
            phoneCalloBj[0].GetComponent<TextMeshProUGUI>().enabled = true;
            phoneSnd.Play();

        }

        if (gameMan.GetComponent<GameManager>().timeTaken >= 280 && gameMan.GetComponent<GameManager>().timeTaken <= 282)
        {
            phoneSnd.Stop();
            currentIndex = 12;
            PCscrImg[0].SetActive(false);
            PCscrImg[1].SetActive(true);
            emailSnd.Play();
            

        }

        if (gameMan.GetComponent<GameManager>().timeTaken >= 310 && gameMan.GetComponent<GameManager>().timeTaken <= 312)
        {

            currentIndex = 2;
            PCscrImg[1].SetActive(false);
            PCscrImg[2].SetActive(true);
            emailSnd.Play();


        }

        if (gameMan.GetComponent<GameManager>().timeTaken >= 340 && gameMan.GetComponent<GameManager>().timeTaken <= 342)
        {

            currentIndex = 3;
            PCscrImg[2].SetActive(false);
            PCscrImg[3].SetActive(true);
            emailSnd.Play();


        }

        if (gameMan.GetComponent<GameManager>().timeTaken >= 370 && gameMan.GetComponent<GameManager>().timeTaken <= 372)
        {

            animCanv.SetActive(true);
            anim.GetComponent<Animator>().SetTrigger(trigName);


        }

    }

}
