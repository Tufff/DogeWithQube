﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMove : MonoBehaviour
{
    [SerializeField]
    float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed *= -1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + speed * Time.fixedDeltaTime);
    }
}
