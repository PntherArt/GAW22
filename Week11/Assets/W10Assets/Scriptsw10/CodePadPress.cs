using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class CodePadPress : MonoBehaviour
{
    //This handles the button presses for each number on the safe
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
    

    //This allows for the number to be put into the safe number screen above the number pad
    private void OnMouseDown()
    {
        ButtonPressed(buttonValue);
        buttonAudio.Play();
    }

}
