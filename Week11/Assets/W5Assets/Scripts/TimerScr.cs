using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerScr : MonoBehaviour
{
    [SerializeField] float initalTime;
    [SerializeField] public float timeTaken;
    public GameObject timeDisplay;
    //public GameObject notifBing;

   public void Start()
    {
        initalTime = Time.time;
    }

    private void FixedUpdate()
    {
        timeTaken = Time.time - initalTime;
        timeDisplay.GetComponent<TextMeshProUGUI>().text = timeTaken.ToString("F2");

        

    }
}
