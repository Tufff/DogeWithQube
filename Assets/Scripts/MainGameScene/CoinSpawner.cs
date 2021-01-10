using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : ObsticleSpawner
{
    // Start is called before the first frame update
    void Start()
    {
        numberOfObsticles = 1;
        groundTransform = GameObject.Find("Ground").transform;
        SpawnRowOfObsticles(obsticle, 1, 45f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
