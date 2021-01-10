using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TunnelDestroyerScript : MonoBehaviour
{
    TunnelSpawner tunnelSpawner;
    // Start is called before the first frame update
    void Start()
    {
        tunnelSpawner = GameObject.Find("GameController").GetComponent<TunnelSpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        string tag = other.tag;
        switch (tag)
        {
            case "Tunnel":
                Destroy(other.gameObject);
                tunnelSpawner.SpawnRandTunnel(new Vector3(0f, -2f, 180f));
                break;
            case "Obsticle":
            case "Coin":
                Destroy(other.gameObject);
                break;
        }
        /*if (other.CompareTag("Tunnel"))
        {
            Destroy(other.gameObject);
            tunnelSpawner.SpawnRandTunnel(new Vector3(0f, -2f, 180f));
        }
        else if (other.CompareTag("Obsticle"))
        {
            Destroy(other.gameObject);
        }*/
    }
}
