using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InteractCntrW7 : MonoBehaviour
{
    //This script controls the inputs for the menu and locking player movement
    InputContr controls;
    InputAction menu;
    [SerializeField] public GameObject pauseUI;
    [SerializeField] private bool isPaused;

    private void Awake()
    {
        controls = new InputContr();
    }

    private void OnEnable()
    {
        menu = controls.PlayerCnt.Interact;
        menu.Enable();
        menu.performed += Pause;
    }

    private void OnDisable()
    {
        menu.Disable();
    }

    void Pause(InputAction.CallbackContext context)
    {
        isPaused = !isPaused;
        if (isPaused)
        {
            ActivateMenu();
        } else
        {
            deactivateMenu();
        }
    }

    public void ActivateMenu()
    {       
        AudioListener.pause = true;
        pauseUI.SetActive(true);
    }


    public void deactivateMenu()
    {     
        AudioListener.pause = false;
        pauseUI.SetActive(false);
        isPaused = false;
    }
}
