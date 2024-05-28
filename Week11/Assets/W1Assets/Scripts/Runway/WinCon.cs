using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCon : MonoBehaviour
{
//This script handles the lift off when the plane enters its trigger box
    public GameObject plane;
    public GameObject[] cnv;

    private void OnTriggerEnter(Collider other)
    {
        cnv[0].SetActive(true);
        plane.transform.Rotate(-20.0f, 0.00f, 00.0f);
        cnv[1].SetActive(false);
    }
}
