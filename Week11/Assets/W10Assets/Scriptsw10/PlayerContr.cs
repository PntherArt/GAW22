using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContr : MonoBehaviour
{
    public Animator anim;
    public float moveSpeed = 5f;

    public Rigidbody2D rb;

    Vector2 movement;

    private void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        anim.SetFloat("Horizontal", movement.x);
        anim.SetFloat("Vertical", movement.y);
        anim.SetFloat("Speed", movement.sqrMagnitude);

        if (Input.GetKeyDown(KeyCode.R))
        {
            this.transform.localPosition = new Vector2(0f, -1.0f);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            print("Quit!");
        }

    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

    }


}
