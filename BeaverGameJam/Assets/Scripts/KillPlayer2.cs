using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer2 : MonoBehaviour
{

    public LevelManager levelManager;
    public GameObject killParticle;

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
        if (other.name == "Player2")
        {
            Instantiate(killParticle, other.transform.position, other.transform.rotation);
            levelManager.RespawnPlayers();
        }
    }
}
