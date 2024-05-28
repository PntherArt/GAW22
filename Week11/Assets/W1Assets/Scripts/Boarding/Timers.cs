using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Timers : MonoBehaviour
{
    //This script handles both the countdown timer to start the game but also the game timer
    [Header("Countdown Timer")]
    public int coundownTime;
    public TextMeshProUGUI countdownDisplay;
    public AudioSource cdSnd;
    public GameObject instrCanv;

    [Header("Game Timer")]
    public float timer = 10;
    public float timeLeft; 
    public float timeCurrent = 10;
    public TextMeshProUGUI timerDisplay;
    public GameObject clockScr;
    public GameObject badScr;
    public GameObject succScr;
    public AudioSource failSnd;

    //This starts the countdown on game entry
    private void Start()
    {
        Cursor.visible = false;
        cdSnd.Play();
        StartCoroutine(CountdownToStart());
    }

    //this handles the actual text updates and also activates the game timer
    IEnumerator CountdownToStart()
    {
        while(coundownTime > 0)
        {
            countdownDisplay.text = coundownTime.ToString();
            yield return new WaitForSeconds(1f);
            coundownTime--;
        }

        countdownDisplay.text = "GO!";
        CustomTimer();
        yield return new WaitForSeconds(1f);
        countdownDisplay.gameObject.SetActive(false);
        instrCanv.SetActive(false);
        
    }

    //This starts the game timer
    [ContextMenu("Start Timer")]
    public void CustomTimer()
    { 
        timeLeft = timer; 
        StartCoroutine(CoroutineTimer(10));

        Debug.Log("AHHHHHH");
    }

    //handles the actual game timer loop, the game fail system and the text updating
    IEnumerator CoroutineTimer(float waitTime)
    { 
        timeCurrent = 10;

        for (int i = 0; i < 1001; i++)
        {
            timerDisplay.text = timeCurrent.ToString("F2");
            yield return new WaitForSeconds(0.01f);
            timeCurrent -= 0.01f;
        }

        if (!succScr.activeSelf)
        {
            print("time's up!");
            clockScr.SetActive(false);
            badScr.SetActive(true);
            failSnd.Play();
        }
    }

}
