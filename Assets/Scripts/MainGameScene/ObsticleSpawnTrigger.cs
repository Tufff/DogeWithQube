using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsticleSpawnTrigger : MonoBehaviour
{
    [SerializeField]
    GameObject[] obsticle, coin;
    ObsticleSpawner obsticleSpawner, coinSpawner;
    // Start is called before the first frame update
    void Start()
    {
        obsticleSpawner = GameObject.Find("GameController").GetComponent<ObsticleSpawner>();
        coinSpawner = GameObject.Find("GameController").GetComponent<CoinSpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ObsticleTrigger"))
        {
            obsticleSpawner.SpawnRowOfObsticles(obsticle);
        }else if (other.CompareTag("CoinTrigger"))
        {
            coinSpawner.SpawnRowOfObsticles(coin, 0, 40f, -0.8f);
        }
    }
}
