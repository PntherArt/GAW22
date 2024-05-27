using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CDTimer : MonoBehaviour
{
    public int coundownTime;
    public TextMeshProUGUI countdownDisplay;

    private TimeSpan timePlaying;
    private bool timerGoing;

    private float elapsedTime;

    public AudioSource cdSnd;

    public GameObject instrCanv;


    private void Start()
    {
        Cursor.visible = false;
        cdSnd.Play();
        StartCoroutine(CountdownToStart());
      
    }

    IEnumerator CountdownToStart()
    {
        while(coundownTime > 0)
        {
            countdownDisplay.text = coundownTime.ToString();

            yield return new WaitForSeconds(1f);

            coundownTime--;
        }

        countdownDisplay.text = "GO!";
        //gameObject.GetComponent<InputCtr>().GameStart();
        gameObject.GetComponent<TimerAndCoroutineExample>().CustomTimer();


        yield return new WaitForSeconds(1f);

        countdownDisplay.gameObject.SetActive(false);
        instrCanv.SetActive(false);
        
    }
}
