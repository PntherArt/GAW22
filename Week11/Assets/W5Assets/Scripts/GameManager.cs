using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    [Header("Menu Controller")]
    public GameObject pauseMenu;

    [Header("Clock Display")]
    public GameObject clockDis;
    public int hour;
    public int minutes;

    [Header("Game Timer")]
    [SerializeField] float initalTime;
    [SerializeField] public float timeTaken;
    public GameObject timeDisplay;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        initalTime = Time.time; //Game Timer
    }

    //handles the updates of the actual time in game
    private void FixedUpdate()
    {
        timeTaken = Time.time - initalTime;
        timeDisplay.GetComponent<TextMeshProUGUI>().text = timeTaken.ToString("F2");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenu.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
        }
        
        //clock display updater
        hour = System.DateTime.Now.Hour;
        minutes = System.DateTime.Now.Minute;
        clockDis.GetComponent<TextMeshProUGUI>().text = "" + hour + ":" + minutes;

    }

    public void BackBtn()
    {
        pauseMenu.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void QuitBtn()
    {
        Application.Quit();
        print("Quit!");
    }



}


