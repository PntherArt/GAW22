using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuCntr : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] public GameObject[] CnvUI;
    [SerializeField] public Button qtButton;
    [SerializeField] public Button plButton;
    

    void Start()
    {
        CnvUI[0].SetActive(true);
        CnvUI[1].SetActive(true);

        StartCoroutine(TitleBye());

    }

   IEnumerator TitleBye()
    {
        yield return new WaitForSeconds(2f);
        CnvUI[1].SetActive(false);
        CnvUI[2].SetActive(true);
        CnvUI[3].SetActive(true);

    }


    public void GameBye()
    {
        Application.Quit();
        Debug.Log("QUIT!");
    }

    public void ButtonMoveScene(string level)
    {
        SceneManager.LoadScene(level);
        Debug.Log("Loaded");
    }

}
