using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public GameObject respawnPointP1;
    public GameObject respawnPointP2;
    public GameObject player1;
    public GameObject player2;
    public GameObject collectManager;
    public GameObject player1Goal;
    public GameObject player2Goal;
    public string nextLevel;

    private CollectiblePickup[] coinsList;
    private LevelLoader p1LevelLoader;
    private LevelLoader p2LevelLoader;

    

    public float respawnDelay;

    void Start()
    {
        coinsList = FindObjectsOfType<CollectiblePickup>();
        p1LevelLoader = player1Goal.GetComponent<LevelLoader>();
        p2LevelLoader = player2Goal.GetComponent<LevelLoader>();
    }

    void Update()
    {
        if(p1LevelLoader.playerInZone && p2LevelLoader.playerInZone && CollectManager.remaningCollectables == 0 && (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)))
        {
            Debug.Log("Level Complete!");
            SceneManager.LoadScene(nextLevel);
        }
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
