using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class FloatObj : MonoBehaviour
{
    //This script handles the floating objects in the portal/water
    public Transform[] floaters;
    public float underWaterDrag = 3;
    public float underWaterAngDrag = 1;
    public float airDrag = 0;
    public float airAngDrag = 0.05f;
    public float floatingPower = 15f;
    public float waterHeight = 0f;
    Rigidbody m_Rigidbody;
    int floatersUnderwater;
    bool underwater;

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {
        //Handles the water bobbing
        floatersUnderwater = 0;
        for (int i = 0; i < floaters.Length; i++)
        {     
            float diff = floaters[i].position.y - waterHeight;
            if (diff < 0)
            {
                m_Rigidbody.AddForceAtPosition(Vector3.up * floatingPower * Mathf.Abs(diff), floaters[i].position, ForceMode.Force);
                floatersUnderwater += 1;
                if (!underwater)
                {
                    underwater = true;
                    SwitchState(true);
                }
            } else if(underwater && floatersUnderwater == 0)
                {
                    underwater = false;
                    SwitchState(false);
                }

        }
    }

    //drags the object out of the water if its underwater
    public void SwitchState (bool isUnderwater)
    {
        if (isUnderwater)
        {
            m_Rigidbody.drag = underWaterDrag;
            m_Rigidbody.angularDrag = underWaterAngDrag;
        } else
        {
            m_Rigidbody.drag = airDrag;
            m_Rigidbody.angularDrag = airAngDrag;
        }
    }



}
