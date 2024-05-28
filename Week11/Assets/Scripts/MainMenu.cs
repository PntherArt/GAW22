using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Animator anim;
    public string trigName;

    public GameObject[] canvas;

    public void Start()
    {
        anim.GetComponent<Animator>();
    }

    public void AnimStart()
    {
        canvas[0].SetActive(false);
        canvas[1].SetActive(false);
        canvas[2].SetActive(true);
        
        anim.SetTrigger(trigName);
    }
    

    public void InstrLoad()
    {
        canvas[0].SetActive(false);
        canvas[1].SetActive(true);
    }

    public void BackBtn()
    {
        canvas[1].SetActive(false);
        canvas[0].SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
        print("Quit!");
    }
}
