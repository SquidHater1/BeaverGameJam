using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject respawnPointP1;
    public GameObject respawnPointP2;
    public GameObject player1;
    public GameObject player2;

    public float respawnDelay;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void RespawnPlayers()
    {
        StartCoroutine("RespawnPlayerCo");
    }

    public IEnumerator RespawnPlayerCo()
    {
        Debug.Log("Players Respawn");
        player1.SetActive(false);
        player2.SetActive(false);
        yield return new WaitForSeconds(respawnDelay);
        player1.SetActive(true);
        player2.SetActive(true);
        player1.transform.position = respawnPointP1.transform.position;
        player2.transform.position = respawnPointP2.transform.position;
    }
}
