using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Painting : MonoBehaviour
{
    //This script handles the painting sequence 
    public GameObject[] paintings;
    public GameObject[] box;
    public GameObject trig;
    public GameObject paintingcav;
    int index = 0;
    public AudioSource snd;

    private void OnMouseOver()
    {
       //This activates the series of canvases to do with the painting and sounds
        if (Input.GetMouseButtonDown(0))
        {
            paintings[index].SetActive(true);
            snd.Play();
            print(index);
            index++;
            
        }

        //this activates the next sequence in the scene
        if(index == 4)
        {
            paintingcav.SetActive(false);
            box[0].SetActive(true);
            box[1].SetActive(true);
            trig.SetActive(false);
        }

    }
}
