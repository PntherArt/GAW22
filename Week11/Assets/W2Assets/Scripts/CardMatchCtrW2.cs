using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardMatchCtr : MonoBehaviour
{
   
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
