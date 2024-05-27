using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgBar : MonoBehaviour
{

    public Slider slids;
    public float targetProgress = 0;

    public float fillSpeed = 0.5f;

    

    private void Start()
    {
        slids = gameObject.GetComponent<Slider>();
        
    }
    void Update()
    {
        if (slids.value < targetProgress)
        {
            slids.value += fillSpeed * Time.deltaTime;
        }

        
    }

    public void IncrementProgress(float newProgress)
    {
        targetProgress = slids.value + newProgress;
    }

}
