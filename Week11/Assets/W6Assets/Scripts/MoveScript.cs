using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{

    Rigidbody m_Rigidbody;
    public float speed = 20f;

    void Start()
    {

        m_Rigidbody = GetComponent<Rigidbody>();

    }

    private void FixedUpdate()
    {
        m_Rigidbody.AddForce(transform.up * speed);
    }
}
