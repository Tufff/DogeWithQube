using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsticleScript : MonoBehaviour
{
    [SerializeField]
    GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        foreach(GameObject go in Resources.FindObjectsOfTypeAll(typeof(GameObject)) as GameObject[])
        {
            if(go.name == "Canvas")
            {
                canvas = go;
                break;
            }
        }
        //canvas = GameObject.Find("canvas");
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
            canvas.SetActive(true);
        }
    }
}
