using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HoverScpt : MonoBehaviour
{
    public GameObject cardObj;
    public Image cardImg;
    public Animator anim;
    public string trigName;
    

   


    public void OnMouseOver()
    {
            cardImg.gameObject.SetActive(true);
            
            cardObj.GetComponent<Animator>().SetTrigger(trigName);
        

    }

    public void OnMouseExit()
    {
        cardImg.gameObject.SetActive(false);
        
    }


}
