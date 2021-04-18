using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoader : MonoBehaviour
{
    public int Player1Or2;
    public bool playerInZone;

    void Start()
    {
        playerInZone = false;
    }


    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (Player1Or2 == 1 && other.name == "Player1")
        {
            playerInZone = true;
            Debug.Log("Player 1 on the exit!");
        }else if(Player1Or2 == 2 && other.name == "Player2")
        {
            playerInZone = true;
            Debug.Log("Player 2 on the exit!");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (Player1Or2 == 1 && other.name == "Player1")
        {
            playerInZone = false;
            Debug.Log("Player 1 off the exit!");
        }
        else if (Player1Or2 == 2 && other.name == "Player2")
        {
            playerInZone = false;
            Debug.Log("Player 2 off the exit!");
        }
    }
}
