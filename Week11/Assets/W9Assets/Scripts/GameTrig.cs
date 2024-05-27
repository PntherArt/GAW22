using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameTrig : MonoBehaviour
{
    public GameObject[] canv;

   

    public GameObject[] items;

    public static bool collected = false;
    private bool isTrig = false;
    public bool triggered = false;

    public string level;

    private void Start()
    {
        
    }

    private void Update()
    {

      

        if (!items[0].activeInHierarchy && !items[1].activeInHierarchy && !items[2].activeInHierarchy)
        {
            collected = true;
            isTrig = false;
        }

        if (collected == true && isTrig == false)
        {
            isTrig = true;
            Invoke("nextScene", 2f);
        }

    }

    


    void nextScene()
    {
        SceneManager.LoadScene(level);
    }


}
