using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AccessAdjust : MonoBehaviour
{
    public float fOV;
    public float masterVol;
    public float sfxVol;

    public GameObject[] BackGAud;
    public GameObject[] sfxAud;
    public GameObject playerCam;

    public TextMeshProUGUI[] myText;
    public Slider[] mySlider;

    private void Start()
    {
        playerCam.GetComponent<GameObject>();

        fOV = 60f;
        masterVol = 0.5f;
        sfxVol = 0.5f;

    }
    

    private void Update()
    {
        Camera.main.fieldOfView = fOV;


        for(var i = 0; i < BackGAud.Length; i++)
        {
            BackGAud[i].GetComponent<GameObject>();
            BackGAud[i].GetComponent<AudioSource>().volume = masterVol;
        }

        for (var i = 0; i < sfxAud.Length; i++)
        {
            sfxAud[i].GetComponent<GameObject>();
            sfxAud[i].GetComponent<AudioSource>().volume = sfxVol;
        }

    }
    public void AdjFOV(float newFOV)
    {
        myText[0].text = newFOV.ToString("0");
        fOV = mySlider[0].value;
    }

    public void AdjMasVol(float newMV)
    {
        myText[2].text = newMV.ToString("0.0");
        masterVol = mySlider[2].value;
    }

    public void AdjSfx(float newSFX)
    {
        myText[3].text = newSFX.ToString("0.0");
        sfxVol = mySlider[3].value;
    }
}
