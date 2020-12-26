using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsticleSpawner : MonoBehaviour
{
    public GameObject obsticle;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(obsticle, new Vector3(0f, -0.5f, 1f), Quaternion.identity, GameObject.Find("Ground").transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
