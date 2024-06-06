using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerSwitch : MonoBehaviour
{
    //This script parents both players to the same "body" so that the left and right game controllers control the correct arm
    private int index = 0;
    [SerializeField] List<GameObject> arms = new List<GameObject>();
    PlayerInputManager manager;
    public GameObject camobj;    

    private void Start()
    {
        manager = GetComponent<PlayerInputManager>();       
    }

    //This checks the new arm to the correct side and when R clone is created it parents
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

    //This parents both the left arm and right arm together under the same gameobject or "body"
    public void ParentTime()
    {
        GameObject.Find("Arm_L(Clone)").transform.SetParent(camobj.transform);
        GameObject.Find("Arm_R(Clone)").transform.SetParent(camobj.transform);
    }
    

}


