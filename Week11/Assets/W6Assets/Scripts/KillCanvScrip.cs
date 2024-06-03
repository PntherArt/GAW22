using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillCanvScrip : MonoBehaviour
{

    public GameObject canv1;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("byeCanv", 12f);
    }

    
    void byeCanv()
    {
        canv1.SetActive(false);
    }
}
