using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class DiaWaitScript : MonoBehaviour
{
    public float delay = 0.1f;
    public string fullText;
    private string currentText = "";

    private void Start()
    {
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

    void Dia2()
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
