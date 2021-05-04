﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    GameObject canvas;
    Transform playerTransform;
    GameObject canvasScore;
    Text coins;


    int money = 0;
    void Awake()
    {
        money = PlayerPrefs.GetInt("Money", 0);
        foreach (GameObject go in Resources.FindObjectsOfTypeAll(typeof(GameObject)) as GameObject[])
        {
            if (go.name == "AfterDeath")
            {
                canvas = go;
                break;
            }
        }
    }
    void Start()
    {
        canvasScore = GameObject.Find("Canvas");
        coins = canvasScore.gameObject.transform.GetChild(1).gameObject.GetComponent<Text>();
        coins.text = PlayerPrefs.GetInt("Money", 0).ToString();
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GameOver()
    {
        Time.timeScale = 0f;
        canvas.SetActive(true);
        PlayerPrefs.SetInt("Money", money);
        playerTransform.position = new Vector3(2.139f, 2f, playerTransform.position.z);
    }

    public void AddMoney(int v = 1)
    {
        money += v;
        coins.text = money.ToString();
    }

    public void RemoveMoney(int v = 0)
    {
        money -= v;
        PlayerPrefs.SetInt("Money", money);
        coins.text = money.ToString();
    }

    public int GetMoney()
    {
        return money;
    }

    public void RemoveMoney(int v = 0)
    {
        money -= v;
    }
}
