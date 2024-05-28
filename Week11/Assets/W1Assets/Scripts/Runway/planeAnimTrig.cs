using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planeAnimTrig : MonoBehaviour
{
    //This script controls the animation for the non player planes
    public Animator anim;
    public string triggerName;

    private void OnTriggerEnter(Collider other)
    {
        anim.GetComponent<Animator>().SetTrigger(triggerName);
    }


}
