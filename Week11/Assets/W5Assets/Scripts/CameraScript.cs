using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    Vector2 rotate = Vector2.zero;
    public float speed = 3;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        rotate.y += Input.GetAxis("Mouse X");
        rotate.y = Mathf.Clamp(rotate.y, -30f, 30f);

        rotate.x -= Input.GetAxis("Mouse Y");
        rotate.x = Mathf.Clamp(rotate.x, -30f, 30f);
        transform.eulerAngles = (Vector2)rotate * speed;
        


    }
}
