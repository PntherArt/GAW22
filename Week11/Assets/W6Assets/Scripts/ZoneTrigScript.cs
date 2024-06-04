using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ZoneTrigScript : MonoBehaviour
{
    //This script handles the level management and removing the canvas at the end of dialouge sequence
    [Header("Zone Trigger")]
    public string level;

    [Header("Canvas Remove")]
    public GameObject canv1;

    private void Start()
    {
        Invoke("byeCanv", 12f);
    }

    //Loads the next scene when player collides with cube
    private void OnTriggerEnter(Collider other)
    {
        print("Ah");
        SceneManager.LoadScene(level);
    }

    //Turns the dialouge canvas off
    void byeCanv()
    {
        canv1.SetActive(false);
    }

}
