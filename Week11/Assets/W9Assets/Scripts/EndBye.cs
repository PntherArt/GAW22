using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndBye : MonoBehaviour
{
    public Animator anim;
    public string trigName;
    public GameObject[] animCanv;


    private void Start()
    {
        animCanv[0].SetActive(true);
    }

    public void AnimStart()
    {
        animCanv[1].SetActive(true);
        anim.GetComponent<Animator>().SetTrigger(trigName);
    }


}
