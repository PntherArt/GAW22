using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class CodePadPress : MonoBehaviour
{

    public static event Action<string> ButtonPressed = delegate { };

    private int deviderPosition;
    private string buttonName, buttonValue;

    [SerializeField] AudioSource buttonAudio;

    // Start is called before the first frame update
    void Start()
    {
        buttonName = gameObject.name;
        deviderPosition = buttonName.IndexOf("_");
        buttonValue = buttonName.Substring(0, deviderPosition);
        buttonAudio = GetComponent<AudioSource>();

    }
    

    private void OnMouseDown()
    {
        ButtonPressed(buttonValue);
        buttonAudio.Play();
    }

}
