using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject respawnPointP1;
    public GameObject respawnPointP2;
    public GameObject player1;
    public GameObject player2;
    

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void RespawnPlayers()
    {
        Debug.Log("Players Respawn");
        player1.transform.position = respawnPointP1.transform.position;
        player2.transform.position = respawnPointP2.transform.position;
    }
}
