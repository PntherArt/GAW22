using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SupermarketTrig : MonoBehaviour
{
    //This handles the names above items in the supermarket
    public GameObject trigger;
    public GameObject nameTag;
    public AudioSource snd;

    //Sets the nametag to be false
    void Start()
    {
        nameTag.SetActive(false);
    }

    //Allows the nametag to be triggered
    private void OnMouseOver()
    {
        nameTag.SetActive(true);
        if (Input.GetMouseButtonDown(0))
        {
            snd.Play();
            trigger.SetActive(false);
        }
    }

    //Disables the namtag
    private void OnMouseExit()
    {
        nameTag.SetActive(false);
    }

}
