using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MenuCntrW7 : MonoBehaviour
{

    InputContr controls;
    InputAction menu;

    [SerializeField] public GameObject pauseUI;
    [SerializeField] private bool isPaused;

    private void Awake()
    {
        controls = new InputContr();
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        menu = controls.PlayerCnt.Pause;
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
        Time.timeScale = 0f;
        AudioListener.pause = true;
        pauseUI.SetActive(true);
    }


    public void deactivateMenu()
    {
        Time.timeScale = 1f;
        AudioListener.pause = false;
        pauseUI.SetActive(false);
        isPaused = false;
    }
}
