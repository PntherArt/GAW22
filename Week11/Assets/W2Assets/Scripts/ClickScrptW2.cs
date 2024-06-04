using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickScrptW2 : MonoBehaviour
{
    //This script shows the english underneath the card on click
    public GameObject cardObj;
    public Image animCardImg;
    public AudioSource cFlipSnd;
   

    public void OnMouseOver()
    {       
        if (Input.GetMouseButton(1))
        {           
            cardObj.gameObject.SetActive(false);
            animCardImg.gameObject.SetActive(false);
            cFlipSnd.Play();
            StartCoroutine(cardFlicker());
        }
        
    }

    IEnumerator cardFlicker()
    {       
        yield return new WaitForSeconds(2f);
        cardObj.gameObject.SetActive(true);       
    }


}
