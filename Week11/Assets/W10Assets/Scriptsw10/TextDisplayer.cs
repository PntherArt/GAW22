using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextDisplayer : MonoBehaviour
{
    
    [SerializeField] TextMeshProUGUI displayText;
    
 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void activate(string textToDisplay)
    {
        
        displayText.text = textToDisplay;
    }

}
