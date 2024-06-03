using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject canvasObj;

    public string level;

    public void Start()
    {
        
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void CanvasTrig()
    {
        canvasObj.SetActive(true);
    }

    public void SceneChange()
    {
        SceneManager.LoadScene(level);
    }




}
