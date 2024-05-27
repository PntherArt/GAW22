using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxAnim : MonoBehaviour
{

    public GameObject[] boxes;

    public GameObject[] anim;

    public BoxCollider boxC;

    public GameObject btnToGo;
    public GameObject Post;

    public AudioSource[] snd;

    

    private void Start()
    {
        
    }



    private void OnMouseOver()
    {

        if (Input.GetMouseButtonDown(0))
        {
            
            StartCoroutine(AnimBox());

        }


    }

    IEnumerator AnimBox()
    {
        anim[0].GetComponent<Animator>().SetTrigger("Tita");
        yield return new WaitForSeconds(2f);
        snd[0].Play();
        anim[0].SetActive(false);
        boxes[0].SetActive(true);


        anim[1].GetComponent<Animator>().SetTrigger("Pen");
        yield return new WaitForSeconds(2f);
        snd[0].Play();
        anim[1].SetActive(false);
        boxes[1].SetActive(true);


        anim[2].GetComponent<Animator>().SetTrigger("Lol");
        yield return new WaitForSeconds(2f);
        snd[0].Play();
        anim[2].SetActive(false);
        anim[3].GetComponent<Animator>().SetTrigger("Tea");
        yield return new WaitForSeconds(2f);
        snd[0].Play();
        anim[3].SetActive(false);
        boxes[2].SetActive(true);

        anim[4].GetComponent<Animator>().SetTrigger("Dice");
        yield return new WaitForSeconds(2f);
        snd[0].Play();
        anim[4].SetActive(false);
        boxes[3].SetActive(true);

        yield return new WaitForSeconds(2f);
        snd[0].Play();
        boxes[4].SetActive(true);

        yield return new WaitForSeconds(2f);
        snd[1].Play();
        boxes[5].SetActive(true);

        yield return new WaitForSeconds(2f);
        btnToGo.SetActive(true);
        boxC.GetComponent<BoxCollider>().enabled = false;
    }


    public void PostOffice()
    {
        boxes[5].SetActive(false);
        Post.SetActive(true);
        btnToGo.SetActive(false);
        
    }


}