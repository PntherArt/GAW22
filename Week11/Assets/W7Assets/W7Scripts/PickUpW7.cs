using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PickUpW7 : MonoBehaviour
{

    InputContr controls;
    InputAction Pick;
    InputAction Down;

    public Transform theDest;

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

    void PickUpObj(InputAction.CallbackContext context)
    {
        GetComponent<BoxCollider>().enabled = false;
        GetComponent<Rigidbody>().useGravity = false;
        this.transform.position = theDest.position;
        this.transform.parent = GameObject.Find("Destination").transform;
    }

    void PutDownObj(InputAction.CallbackContext context)
    {
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<BoxCollider>().enabled = true;
    }


}

