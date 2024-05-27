using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SupermarketTrig : MonoBehaviour
{
    public GameObject trigger;

    public GameObject nameTag;

    public AudioSource snd;

    void Start()
    {
        nameTag.SetActive(false);
    }

    private void OnMouseOver()
    {
        nameTag.SetActive(true);
        if (Input.GetMouseButtonDown(0))
        {
            snd.Play();
            trigger.SetActive(false);
            
        }

    }

    private void OnMouseExit()
    {
        nameTag.SetActive(false);
    }



}
