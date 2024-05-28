using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneCtr : MonoBehaviour
{
    //This script handles the scenes of Week 1's Game
    public string level;
    public GameObject timerScr;
    public GameObject succScr;
    public GameObject failScr;
    public Rigidbody rigibod;
    public AudioSource succSnd;

    public void OnTriggerEnter(Collider other)
    {
        //This triggers the success canvas and sound
        failScr.SetActive(false);
        timerScr.SetActive(false);
        succScr.SetActive(true);
        succSnd.Play();

        Destroy(rigibod);
        StartCoroutine(sceneSwap());

    }


    IEnumerator sceneSwap()
    {
        //this triggers the next game scene
        yield return new WaitForSeconds(4f);
        SceneManager.LoadScene(level);

    }



}
