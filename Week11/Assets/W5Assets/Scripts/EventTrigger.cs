using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EventTrigger : MonoBehaviour
{
    public GameObject[] notifObj;
    
    public GameObject[] tabsCanv;
    public GameObject camObj;

    public GameObject[] scrTabs;

    

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Invoke("Uploaded", 1);
            Invoke("Notif", 3);

        }

        

    }

    public void Uploaded()
    {
        notifObj[0].GetComponent<TextMeshProUGUI>().enabled = true;
    }

    public void Notif()
    {
        tabsCanv[0].SetActive(false);
        tabsCanv[1].SetActive(true);
        scrTabs[0].SetActive(false);
        scrTabs[1].SetActive(true);
    }

   

}
