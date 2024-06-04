using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardMatchCtrW2 : MonoBehaviour
{
   //This script combines the picture, japanese and english together and turns those off during match
    public GameObject[] CardObj;
    public GameObject trigObj;
    public AudioSource cFlipSnd;

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            cFlipSnd.Play();
            CardObj[0].gameObject.SetActive(false);
            CardObj[1].gameObject.SetActive(false);
            CardObj[2].gameObject.SetActive(false);
            trigObj.gameObject.SetActive(false);

        }
    }
}
