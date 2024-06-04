using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W6Manager : MonoBehaviour
{
    //This script handles the proc generation of each level
    [Header("Item Spawner")]
    public GameObject itemToSpread;
    public float itemXSpread = 10;
    public float itemYSpread = 0;
    public float itemZSpread = 10;
    public int numItemsToSpawn = 10;

    [Header("No Overlap")]
    public GameObject[] itemsToPickFrom;
    public float raycastDist = 100f;
    public float overlapTestBoxSize = 1f;
    public LayerMask spawnObjLayer;

    [Header("Seed Generator")]
    public string GameSeed = "Default";
    public int CurrentSeed = 0;

    public void Awake()
    {
        //This generates the seed
        CurrentSeed = GameSeed.GetHashCode();
        Random.InitState(CurrentSeed);
    }

    void Start()
    {
        //This spawns the buildings & makes sure to minimize overlap
        for (int i = 0; i < numItemsToSpawn; i++)
        {
            SpreadItem();
        }

        PositionRaycast();
    }

    //This spreads the buildings out across the seed
    void SpreadItem()
    {
        Vector3 randPosition = new Vector3(Random.Range(-itemXSpread, itemXSpread), Random.Range(-itemYSpread, itemYSpread), Random.Range(-itemZSpread, itemZSpread)) + transform.position;
        GameObject clone = Instantiate(itemToSpread, randPosition, Quaternion.identity);
    }

    //This creates the overlap prevention
    void PositionRaycast()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, raycastDist))
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

    //This picks a building to spawn in
    void Pick(Vector3 positionToSpawn, Quaternion rotationToSpawn)
    {
        int randomIndex = Random.Range(0, itemsToPickFrom.Length);
        GameObject clone = Instantiate(itemsToPickFrom[randomIndex], positionToSpawn, rotationToSpawn);
    }

}
