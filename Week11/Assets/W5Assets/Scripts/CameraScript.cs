using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    //This script pairs the camera movement to the cursor movement
    Vector2 rotate = Vector2.zero;
    public float speed = 3;

    private void Start()
    {
        //Locks the cursor to the centre point on the canvas
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        //Handles the actual input and rotations
        rotate.y += Input.GetAxis("Mouse X");
        rotate.y = Mathf.Clamp(rotate.y, -30f, 30f);

        rotate.x -= Input.GetAxis("Mouse Y");
        rotate.x = Mathf.Clamp(rotate.x, -30f, 30f);
        transform.eulerAngles = (Vector2)rotate * speed;
        


    }
}
