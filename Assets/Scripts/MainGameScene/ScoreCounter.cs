using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    float startPositionZ;
    int score;
    int previousScore;
    Text canvasScore;
    GroundMove groundMove;

    void Start()
    {
        groundMove = gameObject.GetComponent<GroundMove>();
        canvasScore = GameObject.Find("Canvas").transform.GetChild(0).gameObject.GetComponent<Text>();
        startPositionZ = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        previousScore = score;
        score = (int)(transform.position.z + startPositionZ) / -5;
        if (score != previousScore)
        {
            groundMove.ChangeSpeed(0.01f);
        }
        canvasScore.text = score.ToString();
    }

    public int GetScore()
    {
        return score;
    }
}
