using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodeDisplay : MonoBehaviour
{
    //This is the script that handles the entire safe sequence
    [SerializeField] private Sprite[] digits;
    [SerializeField] private Image[] characters;
    [SerializeField] TextDisplayer displayer;
    public bool isActive = true;
    [SerializeField] AudioSource openAudio;
    [SerializeField] AudioSource errorAudio;
    private string codeSequence; 

    // Start is called before the first frame update
    void Start()
    {
        codeSequence = "";

        for (int i = 0; i <= characters.Length -1; i++)
        {
            characters[i].sprite = digits[10];
        }

        CodePadPress.ButtonPressed += AddDigitToCodeSequence;

    }

    //This giant switch case handles all of the inputs so that they can be displayed
    private void AddDigitToCodeSequence(string digitEntered)
    {
        if (codeSequence.Length < 4)
        {
            switch (digitEntered)
            {
                case "Zero":
                    codeSequence += "0";
                    DisplayCodeSequence(0);
                    break;
                case "One":
                    codeSequence += "1";
                    DisplayCodeSequence(1);
                    break;
                case "Two":
                    codeSequence += "2";
                    DisplayCodeSequence(2);
                    break;
                case "Three":
                    codeSequence += "3";
                    DisplayCodeSequence(3);
                    break;
                case "Four":
                    codeSequence += "4";
                    DisplayCodeSequence(4);
                    break;
                case "Five":
                    codeSequence += "5";
                    DisplayCodeSequence(5);
                    break;
                case "Six":
                    codeSequence += "6";
                    DisplayCodeSequence(6);
                    break;
                case "Seven":
                    codeSequence += "7";
                    DisplayCodeSequence(7);
                    break;
                case "Eight":
                    codeSequence += "8";
                    DisplayCodeSequence(8);
                    break;
                case "Nine":
                    codeSequence += "9";
                    DisplayCodeSequence(9);
                    break;
            }
        }

        //These are the enter and reset buttons which are separate as they have specific uses
        switch (digitEntered)
        {
            case "Star":
                ResetDisplay();
                break;

            case "Hash":
                if (codeSequence.Length > 0)
                {
                    CheckResults();
                }
                    break;
        }
    }

    //This is the giant switch case that handles displaying the actual numbers on the screen
    private void DisplayCodeSequence(int digitJustEntered)
    {
        switch (codeSequence.Length)
        {
            case 1:
                characters[0].sprite = digits[10];
                characters[1].sprite = digits[10];
                characters[2].sprite = digits[10];
                characters[3].sprite = digits[digitJustEntered];
                break;
            case 2:
                characters[0].sprite = digits[10];
                characters[1].sprite = digits[10];
                characters[2].sprite = characters[3].sprite;
                characters[3].sprite = digits[digitJustEntered];
                break;
            case 3:
                characters[0].sprite = digits[10];
                characters[1].sprite = characters[2].sprite;
                characters[2].sprite = characters[3].sprite;
                characters[3].sprite = digits[digitJustEntered];
                break;
            case 4:
                characters[0].sprite = characters[1].sprite;
                characters[1].sprite = characters[2].sprite;
                characters[2].sprite = characters[3].sprite;
                characters[3].sprite = digits[digitJustEntered];
                break;
        }
    }

    //This checks if the sequence is correct, which at the moment, it is 1234 
    void CheckResults()
    {
        if (codeSequence == "1234")
        {
            displayer.activate("Unlocked!");
            isActive = false;
            openAudio.Play();

        } 
        else
        {
            displayer.activate("Error!");
            errorAudio.Play();
            ResetDisplay();
        }
    }

    //This resets the display numbers all back to 0 and the code sequence is reset
    private void ResetDisplay()
    {
        for (int i = 0; i <= characters.Length - 1; i++)
        {
            characters[i].sprite = digits[10];
        }

        codeSequence = "";
    }

    //This destroys any active buttons pressed actions
    private void OnDestroy()
    {
        CodePadPress.ButtonPressed -= AddDigitToCodeSequence;
    }
}
