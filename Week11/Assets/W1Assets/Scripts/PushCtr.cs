using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushCtr : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public Rigidbody rigibod;

    // Update is called once per frame
    void Update()
    {
        rigibod.GetComponent<Rigidbody>().AddForce(0,0, moveSpeed);
        
    }
}
