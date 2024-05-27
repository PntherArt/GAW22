using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planeAnimTrig : MonoBehaviour
{
    public Animator anim;
    public string triggerName;

    private void OnTriggerEnter(Collider other)
    {
        anim.GetComponent<Animator>().SetTrigger(triggerName);
    }


}
