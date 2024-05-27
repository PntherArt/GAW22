using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneOn : MonoBehaviour
{
    public GameObject[] canv;

    // Start is called before the first frame update
    void Start()
    {

        Invoke("PhoneUp", 3f);
        Invoke("PhoneTwo", 20f);
        Invoke("PhoneDown", 30f);

    }

    public void PhoneUp()
    {
        canv[0].SetActive(true);
    }

    public void PhoneTwo()
    {
        canv[0].SetActive(false);
        canv[1].SetActive(true);
    }


    public void PhoneDown()
    {        
        canv[2].SetActive(true);
    }

    public void Byebye()
    {
        canv[0].SetActive(false);
        canv[1].SetActive(false);
        canv[2].SetActive(false);
        canv[3].SetActive(true);
    }
}
