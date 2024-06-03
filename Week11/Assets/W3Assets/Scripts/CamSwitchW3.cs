using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class CamSwitchW3 : MonoBehaviour
{
    //this script handles the camera angles of the game
    public GameObject[] cameraObj;
    public GameObject[] titleObj;
    public Animator anim;
    public string trigName;

    public void Start()
    {
        //this locks the mouse to the center
        anim.GetComponent<Animation>();
        Cursor.lockState = CursorLockMode.Locked;
    }


    private void Update()
    {
        //These control the camera inputs from the player
        if (Input.GetKeyDown(KeyCode.L))
        {        
            cameraObj[0].SetActive(false);
            cameraObj[1].SetActive(true);
            titleObj[0].SetActive(false);
            titleObj[1].SetActive(true);           
        }

        if (Input.GetKeyDown(KeyCode.F))
        {           
            cameraObj[1].SetActive(false);
            cameraObj[0].SetActive(true);
            anim.Play("Empty");

            titleObj[1].SetActive(false);
            titleObj[0].SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            print("Quit");
        }
    }

}
