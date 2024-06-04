using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SasaeruSpecW2 : MonoBehaviour
{
    //This is a special hint sciprt for "To support" Or sasaeru because it doesn't have a picture that works for it
    public GameObject cardObj; 
    public AudioSource cFlipSnd;

    //This pretty much copies the Cick script
    public void OnMouseOver()
    {
        if (Input.GetMouseButton(1))
        {
            cardObj.gameObject.SetActive(false);
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
