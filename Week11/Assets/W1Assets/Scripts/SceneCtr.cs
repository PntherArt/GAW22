using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneCtr : MonoBehaviour
{
    public string level;
    public GameObject timerScr;
    public GameObject succScr;
    public GameObject failScr;

    public Rigidbody rigibod;
    public AudioSource succSnd;

    public void OnTriggerEnter(Collider other)
    {
        failScr.SetActive(false);
        timerScr.SetActive(false);
        succScr.SetActive(true);
        succSnd.Play();

        Destroy(rigibod);
        StartCoroutine(sceneSwap());

    }


    IEnumerator sceneSwap()
    {
        yield return new WaitForSeconds(4f);
        SceneManager.LoadScene(level);

    }



}
