using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTrigger : MonoBehaviour
{
    public GameObject[] rooms;
    public Transform player;
    public AudioSource snd;

    private void Start()
    {
        player.GetComponent<Transform>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        player.localPosition = new Vector2(0f, 0f);
        snd.Play();
        rooms[0].SetActive(false);
        rooms[1].SetActive(true);

        
        
    }


}
