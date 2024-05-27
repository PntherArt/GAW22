using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DiaWaitScript : MonoBehaviour
{
    public float delay = 0.1f;
    public string fullText;
    private string currentText = "";

    

    private void Start()
    {

        Invoke("Dia2", 1f);

    }

    public void Dia2()
    {
        
        StartCoroutine(ShowText());

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


}
