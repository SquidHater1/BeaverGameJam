using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectiblePickup : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (gameObject.layer == LayerMask.NameToLayer("Player1Coin") && other.gameObject.layer == LayerMask.NameToLayer("Player1"))
        {
            Debug.Log("Player1 Touched It's Coin!");
            CollectManager.DectementCollectibles();
            gameObject.SetActive(false);
        }
        else if (gameObject.layer == LayerMask.NameToLayer("Player2Coin") && other.gameObject.layer == LayerMask.NameToLayer("Player2"))
        {
            Debug.Log("Player2 Touched It's Coin!");
            CollectManager.DectementCollectibles();
            gameObject.SetActive(false);
        }
    }

    public void RespawnCoin()
    {
        gameObject.SetActive(true);
    }
}
