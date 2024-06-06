using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextDisplayer : MonoBehaviour
{
    //This script handles the number display on the safe
    [SerializeField] TextMeshProUGUI displayText;

    public void activate(string textToDisplay)
    {
        displayText.text = textToDisplay;
    }

}
