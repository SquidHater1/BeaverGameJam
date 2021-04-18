using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectManager : MonoBehaviour
{
    public static int remaningCollectables;
    public int collectiblesInLevel;

    Text text;

    private void Start()
    {
        text = GetComponent<Text>();
        remaningCollectables = collectiblesInLevel;
    }

    private void Update()
    {
        if (remaningCollectables < 0)
        {
            remaningCollectables = 0;
        }
        text.text = "" + remaningCollectables;
    }

    public static void DectementCollectibles()
    {
        remaningCollectables -= 1;
    }

    public void ResetCount(int numColl)
    {
        remaningCollectables = numColl;
    }
}
