using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InputCtr : MonoBehaviour
{
    //This script handles the movement in week 1 game 1
    public Animator animDodge;
    public string triggerNameL;
    public string triggerNameR;
    public float moveSpeed = 5.0f;
    public Rigidbody rigibod;
    public AudioSource moveSnd;


    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            print("Reset Game");
        }*/

        
            if (Input.GetKeyDown(KeyCode.A))
            {
                animDodge.SetTrigger(triggerNameL);
                moveSnd.Play();
                rigibod.GetComponent<Rigidbody>().AddForce(0, 0, moveSpeed);
        }

            if (Input.GetKeyDown(KeyCode.D))
            {
                animDodge.SetTrigger(triggerNameR);
                moveSnd.Play();
                rigibod.GetComponent<Rigidbody>().AddForce(0, 0, moveSpeed);
        }

    }


}
