using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialougeController : MonoBehaviour
{
    //This script handles all of the dialouge in the game.
    [Header("Dialouge Controls")]
    public float delay = 0.1f;
    public string fullText;
    private string currentText = "";

    [Header("Dialouge Wait")]
    public float delay1 = 0.1f;
    public string fullText1;
    private string currentText1 = "";


    void Start()
    {
        //These invoke the dialouge coroutines
        Invoke("PhoneOn", 1f);
        Invoke("Dia2", 2f);

    }

    //this activates the first phone script
    public void PhoneOn()
    {
        StartCoroutine(ShowText());
    }

    //the dialouge animation that writes the letters
    IEnumerator ShowText()
    {
        for (int i = 0; i < fullText.Length; i++)
        {
            currentText = fullText.Substring(0, i);
            this.GetComponent<TextMeshProUGUI>().text = currentText;

            yield return new WaitForSeconds(delay);
        }
    }

    //the section dialouge animation!
    public void Dia2()
    {
        StartCoroutine(ShowText1());

        IEnumerator ShowText1()
        {
            for (int i = 0; i < fullText1.Length; i++)
            {
                currentText1 = fullText1.Substring(0, i);
                this.GetComponent<TextMeshProUGUI>().text = currentText1;
                yield return new WaitForSeconds(delay1);
            }

        }
    }

}


