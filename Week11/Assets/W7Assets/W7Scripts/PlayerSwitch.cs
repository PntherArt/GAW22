using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerSwitch : MonoBehaviour
{
    private int index = 0;
    [SerializeField] List<GameObject> arms = new List<GameObject>();
    PlayerInputManager manager;
    public GameObject camobj;
    

    private void Start()
    {
        manager = GetComponent<PlayerInputManager>();
        
    }

    public void SwitchNewArm(PlayerInput input)
    {

        manager.playerPrefab = arms[index];
        index = 1;

        if(GameObject.Find("Arm_L(Clone)") == isActiveAndEnabled)
        {
            manager.playerPrefab = arms[index];
            
        }

        if(GameObject.Find("Arm_L(Clone)") == isActiveAndEnabled && GameObject.Find("Arm_R(Clone)") == isActiveAndEnabled)
        {
            ParentTime();
        }

    }


    public void ParentTime()
    {

        GameObject.Find("Arm_L(Clone)").transform.SetParent(camobj.transform);
        GameObject.Find("Arm_R(Clone)").transform.SetParent(camobj.transform);

    }
    

}


