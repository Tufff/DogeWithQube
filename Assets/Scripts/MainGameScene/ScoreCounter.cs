using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    float startPositionZ;
    int score;

    // Start is called before the first frame update
    void Start()
    {
        startPositionZ = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        score = (int)(transform.position.z + startPositionZ) / -5;
        //Debug.Log(score);
    }

    public int GetScore()
    {
        return score;
    }
}
