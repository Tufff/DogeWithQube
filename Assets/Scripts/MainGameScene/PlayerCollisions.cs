using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        switch (collision.collider.tag)
        {
            case "Coin":
                FindObjectOfType<GameManager>().AddMoney();
                Destroy(collision.gameObject);
                break;
            case "Obsticle":
                FindObjectOfType<GameManager>().GameOver();
                break;
        }
    }
}
