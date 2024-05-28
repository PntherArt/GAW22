using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CockPitCtr : MonoBehaviour
{
    //This script controls the cockpit inputs
    [Header("Cockpit Controls")]
    public string level;
    public GameObject timerScr;
    public GameObject succScr;
    public AudioSource succSnd;
    public GameObject btObj;
    public Animator animBtn;
    public string triggerName;
    public GameObject engUI;
    public GameObject clockScr;
    public GameObject badScr;
    public AudioSource failSnd;

    //This controls the progress UI bar
    [Header("Progress Bar")]
    public Slider slids;
    public float targetProgress = 0;
    public float fillSpeed = 0.5f;

    private void Start()
    {
        slids = gameObject.GetComponent<Slider>();
    }

    private void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            print("Reset Game");
        }*/

        //This controls the fillspeed of the progress bar
        if (slids.value < targetProgress)
        {
            slids.value += fillSpeed * Time.deltaTime;
        }
    }

    //This handles the red button in the cockpit
    private void OnMouseOver()
    {
        //This animates the button going down and the progress bar
        if (Input.GetMouseButton(0))
        {
            animBtn.SetTrigger(triggerName);
            IncrementProgress(1f);

        }

        //This triggers the fail sequence
        if (Input.GetMouseButtonUp(0) && !succScr.activeSelf)
        {
            clockScr.SetActive(false);
            badScr.SetActive(true);
            engUI.transform.GetChild(2).gameObject.SetActive(false);
            failSnd.Play();
        }

        //This triggers the success sequence
        if (slids.value == 1f && clockScr.activeSelf)
        {
            StartCoroutine(NextScene());
        }
    }

    //This triggers the next minigame
    public IEnumerator NextScene()
    {
        timerScr.SetActive(false);
        succScr.SetActive(true);
        succSnd.Play();
        yield return new WaitForSeconds(4f);
        SceneManager.LoadScene(level);
    }

    //This controls the value slider on the UI slider 
    public void IncrementProgress(float newProgress)
    {
        targetProgress = slids.value + newProgress;
    }
}
