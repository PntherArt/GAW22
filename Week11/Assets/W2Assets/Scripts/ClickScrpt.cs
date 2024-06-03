using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickScrpt : MonoBehaviour
{
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
