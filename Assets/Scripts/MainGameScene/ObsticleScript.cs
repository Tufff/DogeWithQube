﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsticleScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Time.timeScale = 0f;
        }
    }
    /*
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Time.timeScale = 0f;
        }
    }*/
}
