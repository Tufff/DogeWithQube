using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsticleSpawnTrigger : MonoBehaviour
{
    ObsticleSpawner obsticleSpawner;
    // Start is called before the first frame update
    void Start()
    {
        obsticleSpawner = GameObject.Find("GameController").GetComponent<ObsticleSpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obsticle"))
        {
            obsticleSpawner.SpawnRowOfObsticles();
        }
    }
}
