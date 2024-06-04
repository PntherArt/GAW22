using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class DialougeControllerW6 : MonoBehaviour
{
    [Header("Dialouge Controller")]
    public float delay = 0.1f;
    public string fullText;
    private string currentText = "";

    [Header("Wait Dialouge")]
    public float delay1 = 0.1f;
    public string fullText1;
    private string currentText1 = "";


    void Start()
    {
        //This starts the first dialouge for the scene
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

        //This activates the specific replies for each scene
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        if (sceneName == "Zone1")
        {
            Invoke("Dia2", 2f);
        }

        if (sceneName == "Zone2")
        {
            Invoke("Dia2", 3f);
        }

        if (sceneName == "Zone3")
        {
            Invoke("Dia2", 4f);
        }

        if (sceneName == "Zone4")
        {
            Invoke("Dia2", 5f);
        }
    }

    //This activates the animation for the second dialouge sequence
    void Dia2()
    {
        StartCoroutine(ShowText());
        IEnumerator ShowText()
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
