using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class animloadmenu : MonoBehaviour
{

    public string level;

    public void LoadGame()
    {
        SceneManager.LoadScene(level);
    }
}
