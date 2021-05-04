using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScorePage : MonoBehaviour
{
    ScoreCounter scoreCounter;
    TextMeshProUGUI score;
    TextMeshProUGUI highScore;

    void Start()
    {
        scoreCounter = GameObject.Find("Ground").GetComponent<ScoreCounter>();
        score = transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();
        highScore = transform.GetChild(1).gameObject.GetComponent<TextMeshProUGUI>();
        score.text = scoreCounter.GetScore().ToString();
        if(scoreCounter.GetScore() > PlayerPrefs.GetInt("highScore", 0))
        {
            PlayerPrefs.SetInt("highScore", scoreCounter.GetScore());
        }
        highScore.text = PlayerPrefs.GetInt("highScore", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
