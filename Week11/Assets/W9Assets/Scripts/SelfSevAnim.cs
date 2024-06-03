using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelfSevAnim : MonoBehaviour
{
    //This script handles the self serve sequence in the game
    [Header("Self Serve Animation")]
    public GameObject[] serves;
    public GameObject[] anim;
    public GameObject btnToGo;
    public GameObject[] cav;
    public GameObject[] btn;
    public AudioSource snd;
    public GameObject[] trig;

    [Header("Supermarket Scene")]
    public GameObject[] items;
    public GameObject[] canv;
    public static bool collected = false;
    private bool isTrig = false;

    private void Update()
    {
        //This triggers the item collection from the shelves
        if (cav[1].activeInHierarchy)
        {
            Invoke("GoIn", 1f);
        }
        
        if (!items[0].activeInHierarchy && !items[1].activeInHierarchy && !items[2].activeInHierarchy && !items[3].activeInHierarchy && !items[4].activeInHierarchy)
        {
            collected = true;
            isTrig = false;
        }

        if (collected == true && isTrig == false)
        {
            canv[0].SetActive(false);
            canv[1].SetActive(true);
            isTrig = true;
        }

    }

    //This triggers the self service canvas
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(SelfServ());
        }
    }

    //The animations for the self serve
    IEnumerator SelfServ()
    {
        anim[0].GetComponent<Animator>().SetTrigger("Tita");
        yield return new WaitForSeconds(3f);
        anim[0].SetActive(false);
        serves[0].SetActive(true);

        anim[1].GetComponent<Animator>().SetTrigger("Lol");
        yield return new WaitForSeconds(3f);
        anim[1].SetActive(false);
        serves[1].SetActive(true);

        anim[2].GetComponent<Animator>().SetTrigger("Tea");
        yield return new WaitForSeconds(3f);
        anim[2].SetActive(false);
        serves[2].SetActive(true);

        anim[3].GetComponent<Animator>().SetTrigger("Card");
        yield return new WaitForSeconds(3f);
        anim[3].SetActive(false);

        yield return new WaitForSeconds(2f);
        btnToGo.SetActive(true);

    }

    //Goes into the supermarket
    void GoIn()
    {
        btnToGo.SetActive(false);
        btn[0].SetActive(true);
        btn[1].SetActive(false);
    }

    //Handles the game store sequence
    public void HelloGames()
    {
        cav[0].SetActive(false);
        cav[1].SetActive(true);       
    }

    //Inside the game store sequence
    public void InsideGames()
    {
        snd.Play();
        cav[1].SetActive(false);
        cav[2].SetActive(true);
        trig[0].SetActive(false);
        trig[1].SetActive(true);

        btnToGo.SetActive(false);
        btn[0].SetActive(false);
    }



}
