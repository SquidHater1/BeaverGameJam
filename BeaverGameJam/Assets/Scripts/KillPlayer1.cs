using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer1 : MonoBehaviour
{

    public LevelManager levelManager;

    // Start is called before the first frame update
    void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == "Player1")
        {
            levelManager.RespawnPlayers();
        }
    }
}
