using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PickUpW7 : MonoBehaviour
{
    //This script controls the pickup and items that the player can obtain
    InputContr controls;
    InputAction Pick;
    InputAction Down;
    public Transform theDest;

    private void Awake()
    {
        controls = new InputContr();
    }


    //This allows the pickup action
    private void OnEnable()
    {
        Pick = controls.PlayerCnt.PickUp;
        Pick.Enable();
        Pick.performed += PickUpObj;
        Down = controls.PlayerCnt.PutDown;
        Down.Enable();
        Down.performed += PutDownObj;
    }

    private void OnDisable()
    {
        Pick.Disable();
        Down.Disable();
    }

    //This lets the player pick up the certain item and hold it
    void PickUpObj(InputAction.CallbackContext context)
    {
        GetComponent<BoxCollider>().enabled = false;
        GetComponent<Rigidbody>().useGravity = false;
        this.transform.position = theDest.position;
        this.transform.parent = GameObject.Find("Destination").transform;
    }

    //This lets the player drop the certain item
    void PutDownObj(InputAction.CallbackContext context)
    {
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<BoxCollider>().enabled = true;
    }
}

