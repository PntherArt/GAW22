using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class paperw5pickup : MonoBehaviour
{
    public GameObject scr;
    //bool isTriggered = false;

    private void Start()
    {
        
    }

    public void OnMouseOver()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            //print("working");
            scr.SetActive(true);
        }

    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            
            scr.SetActive(false);
        }
    }

}
