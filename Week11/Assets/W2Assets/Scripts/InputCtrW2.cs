using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InputCtrW2 : MonoBehaviour
{
    //This script handles the end scene, it is basically a end menu manager
    [SerializeField] public GameObject[] CnvUI;
    [SerializeField] public Button plButton;
    [SerializeField] public Button qtButton;
    public AudioSource pageSnd;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pageSnd.Play();
            Application.Quit();
            print("quit");
        }
           
    }

    public void GameBye()
    {
        pageSnd.Play();
        Application.Quit();
        Debug.Log("QUIT!");
    }

    public void ButtonMoveScene(string level)
    {
        pageSnd.Play();
        SceneManager.LoadScene(level);
        Debug.Log("Loaded");
    }
}
