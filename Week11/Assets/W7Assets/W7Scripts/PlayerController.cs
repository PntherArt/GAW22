using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    //This script handles each players controls and uses the joystick input and gamepad btns to control the actions
    private Vector2 rotationInput;
    InputContr controls;

    private void Awake()
    {
        controls = new InputContr();
    }

    private void Update()
    {
        Vector2 r = new Vector2(-rotationInput.y, -rotationInput.x) * 100f * Time.deltaTime;
        transform.Rotate(r, Space.World);
    }

    public void OnRotate(InputAction.CallbackContext ctx) => rotationInput = ctx.ReadValue<Vector2>();
    public void OnPickUp(InputAction.CallbackContext ctx) => rotationInput = ctx.ReadValue<Vector2>();
    public void OnPutDown(InputAction.CallbackContext ctx) => rotationInput = ctx.ReadValue<Vector2>();
    public void OnInteract(InputAction.CallbackContext ctx) => rotationInput = ctx.ReadValue<Vector2>();

}
