using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DatapadTrig : MonoBehaviour
{
    //This script handles the script and trigger of the datapad
    [Header("Trigger")]
    public GameObject datapad;
    public AudioSource snd;

    private void Start()
    {
        var input = gameObject.GetComponent<TMP_InputField>();
        var se = new TMP_InputField.SubmitEvent();
        se.AddListener(SubmitData);
        input.onEndEdit = se;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        snd.Play();
        datapad.SetActive(true);     
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            datapad.SetActive(false);
        }
    }
    private void SubmitData(string data)
    {
        print(data);
    }
}
