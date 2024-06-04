using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HoverScptW2 : MonoBehaviour
{
    //This script handles the hint so it will reveal the picture hint for the word and hide the japanese card
    public GameObject cardObj;
    public Image cardImg;
    public Animator anim;
    public string trigName;

    public void OnMouseOver()
    {
            cardImg.gameObject.SetActive(true);          
            cardObj.GetComponent<Animator>().SetTrigger(trigName);       
    }

    public void OnMouseExit()
    {
        cardImg.gameObject.SetActive(false);       
    }
}
