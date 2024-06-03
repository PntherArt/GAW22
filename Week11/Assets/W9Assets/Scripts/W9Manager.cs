using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class W9Manager : MonoBehaviour
{
    //This script handles all of the main sequences in the scenes
    [Header("Audio")]
    public AudioSource snd;

    [Header("End Bye")]
    public Animator anim;
    public string trigName;
    public GameObject[] animCanv;

    [Header("GameTrig")]
    public GameObject[] canv;
    public GameObject[] items;
    public static bool collected = false;
    private bool isTrig = false;
    public bool triggered = false;
    public string level;

    void Start()
    {
        animCanv[0].SetActive(true);
    }


    void Update()
    {
        //This handles the game store pick up sequence
        if (!items[0].activeInHierarchy && !items[1].activeInHierarchy && !items[2].activeInHierarchy)
        {
            collected = true;
            isTrig = false;
        }

        if (collected == true && isTrig == false)
        {
            isTrig = true;
            Invoke("nextScene", 2f);
        }
    }

    public void playAudio()
    {
        snd.Play();
    }

    //This triggers the ending animation
    public void AnimStart()
    {
        animCanv[1].SetActive(true);
        anim.GetComponent<Animator>().SetTrigger(trigName);
    }

    void nextScene()
    {
        SceneManager.LoadScene(level);
    }
}
