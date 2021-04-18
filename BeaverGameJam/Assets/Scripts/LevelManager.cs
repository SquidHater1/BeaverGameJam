using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject respawnPointP1;
    public GameObject respawnPointP2;
    public GameObject player1;
    public GameObject player2;
    public GameObject collectManager;

    private CollectiblePickup[] coinsList;

    

    public float respawnDelay;

    void Start()
    {
        coinsList = FindObjectsOfType<CollectiblePickup>();
        //for(int i = 0; i < coinsList.Length; i++)
        //{
        //    coins.Add(coinsList[i].gameObject);
        //}
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
        for(int i = 0; i < coinsList.Length; i++)
        {
            coinsList[i].RespawnCoin();
        }
        collectManager.GetComponent<CollectManager>().ResetCount(collectManager.GetComponent<CollectManager>().collectiblesInLevel);
        player1.SetActive(true);
        player2.SetActive(true);
        player1.transform.position = respawnPointP1.transform.position;
        player2.transform.position = respawnPointP2.transform.position;
        
    }
}
