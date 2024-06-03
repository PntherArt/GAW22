using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchRate : MonoBehaviour
{
    //This script handles the random catch rate of the fishes
    private int fishNum;
    public Animator fishAnim;
    public string[] fishTrig;
    public Animator rodAnim;
    public string[] rodTrig;
    public AudioSource[] snd;
    public GameObject reelTitle;
    public GameObject[] fish;
    
    
    private void Start()
    {
        fishAnim.GetComponent<Animator>();
        rodAnim.GetComponent<Animator>();
        fish[0].gameObject.GetComponentInChildren<Renderer>().enabled = true;
    }

    void Update()
    {
        //This is the actual randomizer fish catcher
        if (Input.GetKeyDown(KeyCode.L))
        {
            rodAnim.SetTrigger(rodTrig[0]);
            int fishNum = Random.Range(1, 4);
            print(fishNum);

            if (fishNum == 1)
            {
                fishAnim.SetTrigger(fishTrig[0]);
            }

            if (fishNum == 2)
            {
                fishAnim.SetTrigger(fishTrig[1]);
            }

            if (fishNum == 3)
            {
                fishAnim.SetTrigger(fishTrig[2]);
            }

        }

        //This puts the fish in inventory
        if (Input.GetKeyDown(KeyCode.F))
        {
            fish[1].SetActive(false);
            fish[0].gameObject.GetComponentInChildren<Renderer>().enabled = true;
            fishAnim.SetTrigger(fishTrig[3]);
            rodAnim.SetTrigger(rodTrig[2]);
            snd[1].Stop();
        }

        //This brings the rod back
        if (Input.GetMouseButton(0) && reelTitle.activeSelf)
        {         
            reelTitle.SetActive(false);
            rodAnim.SetTrigger(rodTrig[1]);
        }

    }
    //fish sounds
    public void playFish()
    {
        snd[0].Play();
    }

    //this is the prompt to reel the fish
    public void ReelItIn()
    {
        reelTitle.SetActive(true);
        fish[0].gameObject.GetComponentInChildren<Renderer>().enabled = false;
        rodAnim.SetTrigger(rodTrig[2]);
        fish[1].SetActive(true);
    }

    

    

}
