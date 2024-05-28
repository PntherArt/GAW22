using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlaneCtr : MonoBehaviour
{
    //This script controls the inputs for the plane
    public float speed;
    public GameObject timerScr;

    // Update is called once per frame
    void Update()
    {
        //This handles the speed of the plane
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        /*if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            print("Reset Game");
        }*/

        //These handle the rotation inputs
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Rotate(0.0f, -10.0f, 0.0f);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Rotate(0.0f, 10.0f, 0.0f);
        }
    }

}