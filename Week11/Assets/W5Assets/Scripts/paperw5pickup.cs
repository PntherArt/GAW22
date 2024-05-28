using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class paperw5pickup : MonoBehaviour
{
    //Controls the input for the page on the desk
    public GameObject scr;

    //Turns on the pages canvas
    public void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            scr.SetActive(true);
        }
    }

    //Turns off the pages canvas
    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            scr.SetActive(false);
        }
    }

}
