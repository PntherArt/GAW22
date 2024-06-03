using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class GameMang : MonoBehaviour
{

    public string[] WordList;
    public TextMeshProUGUI wordDisplay;
    public GameObject[] Trig;

    int counter = 0;

    public GameObject[] backgrounds;
    public GameObject[] trigParent;

    public GameObject btnObj;
    public GameObject titleObj;
    public GameObject wordObj;
    
    void Start()
    {
        wordDisplay.text = WordList[0].ToString();
        
    }

  

    private void OnMouseOver()
    {
        for (int i = 0; i < Trig.Length; ++i)
        {

            if(!Trig[8].activeSelf)
            {
                backgrounds[0].SetActive(false);
                backgrounds[1].SetActive(true);

                trigParent[0].SetActive(false);
                trigParent[1].SetActive(true);
            }

            if (!Trig[17].activeSelf)
            {
                backgrounds[1].SetActive(false);
                backgrounds[2].SetActive(true);

                trigParent[1].SetActive(false);
                trigParent[2].SetActive(true);
            }

            if (!Trig[22].activeSelf)
            {
                backgrounds[2].SetActive(false);
                backgrounds[3].SetActive(true);

                trigParent[2].SetActive(false);
                trigParent[3].SetActive(true);
            }

            if (!Trig[29].activeSelf)
            {
                backgrounds[3].SetActive(false);
                backgrounds[4].SetActive(true);

                trigParent[3].SetActive(false);
                trigParent[4].SetActive(true);
            }

            if (!Trig[30].activeSelf)
            {
                backgrounds[4].SetActive(false);
                backgrounds[5].SetActive(true);

                trigParent[4].SetActive(false);
                trigParent[5].SetActive(true);
            }

            if (!Trig[33].activeSelf)
            {
                titleObj.SetActive(false);
                wordObj.SetActive(false);
                btnObj.SetActive(true);
                break;
            }

            if (!Trig[counter].activeInHierarchy)
            {
                counter++;
                NextWord();
                
            }
        }


    }


    public void NextWord()
    {
        for (int i = 0; i < WordList.Length; ++i)
        {
            wordDisplay.text = WordList[counter].ToString();
            
        }

    }

    public void NextScene()
    {
        SceneManager.LoadScene(2);
    }

}
