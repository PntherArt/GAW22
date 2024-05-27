using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialougeController : MonoBehaviour
{
    public float delay = 0.1f;
    public string fullText;
    private string currentText = "";

    
    

    void Start()
    {

        Invoke("PhoneOn", 1f);

    }

    public void PhoneOn()
    {
        
        StartCoroutine(ShowText());
    }

    IEnumerator ShowText()
    {
        for (int i = 0; i < fullText.Length; i++)
        {
            currentText = fullText.Substring(0, i);
            this.GetComponent<TextMeshProUGUI>().text = currentText;

            yield return new WaitForSeconds(delay);


        }

    }

}


