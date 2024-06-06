using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PauseMenu : MonoBehaviour
{
    [Header("Canvases")]
    public GameObject PauCanv;
    public GameObject SettingsCanv;
    public GameObject Canv;
    public GameObject contrCanv;
    bool isTrig = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && isTrig == false)
        {
            isTrig = true;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Canv.SetActive(false);
            PauCanv.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && isTrig == true)
        {
            isTrig = false;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            PauCanv.SetActive(false);
            SettingsCanv.SetActive(false);
            Canv.SetActive(true);
        }

    }

    public void Resume()
    {
        isTrig = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        PauCanv.SetActive(false);
        Canv.SetActive(true);
    }

    public void Settings()
    {
        isTrig = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Canv.SetActive(false);
        PauCanv.SetActive(false);
        SettingsCanv.SetActive(true);
    }

    public void Back()
    {
        isTrig = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Canv.SetActive(false);
        SettingsCanv.SetActive(false);
        contrCanv.SetActive(false);
        PauCanv.SetActive(true);
    }

    public void Controls()
    {
        isTrig = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Canv.SetActive(false);
        PauCanv.SetActive(false);
        contrCanv.SetActive(true);
    }

    public void Quit()
    {
        print("Quit!");
        Application.Quit();
    }
}
