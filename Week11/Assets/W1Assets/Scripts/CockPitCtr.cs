using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CockPitCtr : MonoBehaviour
{

    public string level;
    public GameObject timerScr;
    public GameObject succScr;
    public AudioSource succSnd;

    public GameObject btObj;
    
    public Animator animBtn;
    public string triggerName;

    public GameObject engUI;
    public GameObject holdBar;

    public GameObject clockScr;
    public GameObject badScr;

    public AudioSource failSnd;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            print("Reset Game");
        }
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButton(0))
        {
            animBtn.SetTrigger(triggerName);
            
            holdBar.GetComponent<ProgBar>().IncrementProgress(1f);

        }

        if (Input.GetMouseButtonUp(0) && !succScr.activeSelf)
        {
            clockScr.SetActive(false);
            badScr.SetActive(true);
            engUI.transform.GetChild(2).gameObject.SetActive(false);
            failSnd.Play();
        }

        if (holdBar.GetComponent<ProgBar>().slids.value == 1f && clockScr.activeSelf)
        {
            StartCoroutine(NextScene());
        }

    }

    public IEnumerator NextScene()
    {
        
        timerScr.SetActive(false);
        succScr.SetActive(true);
        succSnd.Play();
        

        yield return new WaitForSeconds(4f);
        SceneManager.LoadScene(level);
    }

    
}
