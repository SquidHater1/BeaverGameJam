using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanupParticles : MonoBehaviour
{

    private ParticleSystem thisSystem;

    void Start()
    {
        thisSystem = GetComponent<ParticleSystem>();
    }


    void Update()
    {
        if (!(thisSystem.isPlaying))
        {
            Destroy(gameObject);
        }
    }
}
