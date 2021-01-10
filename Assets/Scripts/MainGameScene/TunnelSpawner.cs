using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TunnelSpawner : MonoBehaviour
{
    Object[] tunnelsArray;
    int numberOfTunnels = 0;
    Transform transformOfGround;
    void Awake()
    {
        tunnelsArray = Resources.LoadAll("Prefabs/Tunnels", typeof(GameObject));
        numberOfTunnels = 0;
        foreach (Object o in tunnelsArray)
        {
            numberOfTunnels++;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        transformOfGround = GameObject.Find("Ground").transform;
        SpawnRandTunnel(new Vector3(0f, -2f, 2f));
        SpawnRandTunnel(new Vector3(0f, -2f, 180f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnRandTunnel(Vector3 position)
    {
        int randTunnelIndex = Random.Range(0, numberOfTunnels);
        Instantiate(tunnelsArray[randTunnelIndex], position, Quaternion.Euler(0f, 180f, 0f), transformOfGround);
    }
}
