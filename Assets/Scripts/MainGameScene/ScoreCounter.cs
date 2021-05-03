using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    float startPositionZ;
    int score;
    Text canvasScore;

    void Start()
    {
        canvasScore = GameObject.Find("Canvas").transform.GetChild(0).gameObject.GetComponent<Text>();
        startPositionZ = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        score = (int)(transform.position.z + startPositionZ) / -5;
        canvasScore.text = score.ToString();
    }

    public int GetScore()
    {
        return score;
    }
}
