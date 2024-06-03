using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoOverlapScript : MonoBehaviour
{

    public GameObject[] itemsToPickFrom;
    public float raycastDist = 100f;
    public float overlapTestBoxSize = 1f;
    public LayerMask spawnObjLayer;


    void Start()
    {
        PositionRaycast();
    }

    void PositionRaycast()
    {
        RaycastHit hit;
        
        if(Physics.Raycast(transform.position, Vector3.down, out hit, raycastDist))
        {
            Quaternion spawnRotation = Quaternion.FromToRotation(Vector3.up, hit.normal);

            Vector3 overlapTestBoxScale = new Vector3(overlapTestBoxSize, overlapTestBoxSize, overlapTestBoxSize);
            Collider[] collidersInsideOverlapBox = new Collider[1];
            int numberOfCollidersFound = Physics.OverlapBoxNonAlloc(hit.point, overlapTestBoxScale, collidersInsideOverlapBox, spawnRotation, spawnObjLayer);

            print("number of colliders found " + numberOfCollidersFound);

            if (numberOfCollidersFound == 0)
            {
                print("spawned cube");
                Pick(hit.point, spawnRotation);
            }
            else
            {
                print("name of collider 0 found " + collidersInsideOverlapBox[0].name);
            }

        }
    }
   
    void Pick(Vector3 positionToSpawn, Quaternion rotationToSpawn)
    {
        int randomIndex = Random.Range(0, itemsToPickFrom.Length);
        GameObject clone = Instantiate(itemsToPickFrom[randomIndex], positionToSpawn, rotationToSpawn);
    }


}
