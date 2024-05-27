using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerAndCoroutineExample : MonoBehaviour {
  public float timer = 10; //a public variable showing how long we want our timer to count down for;

  [SerializeField] private float timer_timeLeft; //a private variable storing how much time is left in our timer;

  //[SerializeField] private bool timer_Active = false; //a private variable telling us whether our timer is active;
    public float timeCurrent = 10;

    public TextMeshProUGUI timerDisplay;
    public GameObject clockScr;
    public GameObject badScr;
    public GameObject succScr;

    public AudioSource failSnd;


    [ContextMenu ("Start Timer")]
  public void CustomTimer () { //function that starts our custom timer;
    //timer_Active = true; //set our timer to active;
    timer_timeLeft = timer; //and reset the timeleft value to the default timer value;
        StartCoroutine(CoroutineTimer(10));

        Debug.Log("AHHHHHH");
  }

  [ContextMenu ("Start Coroutine Timer")]
  void StartCoroutineTimer () { //function that starts our coroutine timer;
    StartCoroutine (CoroutineTimer (timer)); //coroutines are activated with the "StartCoroutine" function and can be stopped with the "StopCoroutine" function;
  }

  IEnumerator CoroutineTimer (float waitTime) { //coroutine that waits for "waitTime" number of seconds and then does something;

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
