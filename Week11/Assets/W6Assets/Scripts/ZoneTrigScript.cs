using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ZoneTrigScript : MonoBehaviour
{
    public string level;

    private void OnTriggerEnter(Collider other)
    {
        print("Ah");
        SceneManager.LoadScene(level);
    }

}
