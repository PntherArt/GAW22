using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seed : MonoBehaviour
{
    public string GameSeed = "Default";
    public int CurrentSeed = 0;

    public GameObject[] GroundObjs;
    public GameObject[] RockObjs;
    public GameObject[] TreeObjs;


    public int GroundObjectCount = 4;
    public int RockObjectCount = 10;
    public int TreeObjectCount = 5;

    public void Awake()
    {
        CurrentSeed = GameSeed.GetHashCode();
        Random.InitState(CurrentSeed);
    }

    private void Start()
    {
        for(int i = 0; i < GroundObjectCount; i++)
        {
            Vector3 pos = Random.insideUnitSphere * 7;
            pos.y = 0;
            GameObject selected = GroundObjs[Random.Range(0, GroundObjs.Length)];

            GameObject ground = Instantiate(selected, pos, selected.transform.rotation);
            ground.transform.rotation = Quaternion.Euler(-90, Random.Range(0, 360), 0);
        }

        for (int i = 0; i < RockObjectCount; i++)
        {
            Vector3 pos = Random.insideUnitSphere * 7;
            pos.y = 20;
            RaycastHit hit;
            if (Physics.Raycast(pos, Vector3.down, out hit))
            {
                GameObject selected = RockObjs[Random.Range(0, RockObjs.Length)];

                GameObject ground = Instantiate(selected, hit.point, selected.transform.rotation);
                ground.transform.rotation = Quaternion.Euler(-90, Random.Range(0, 360), 0);
            }
            
        }

        for (int i = 0; i < TreeObjectCount; i++)
        {
            Vector3 pos = Random.insideUnitSphere * 7;
            pos.y = 20;
            RaycastHit hit;
            if (Physics.Raycast(pos, Vector3.down, out hit))
            {
                GameObject selected = TreeObjs[Random.Range(0, TreeObjs.Length)];

                GameObject ground = Instantiate(selected, hit.point, selected.transform.rotation);
                ground.transform.rotation = Quaternion.Euler(-90, Random.Range(0, 360), 0);
            }

        }

    }
}
