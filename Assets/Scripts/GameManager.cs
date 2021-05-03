using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    GameObject canvas;


    int money = 0;
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
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
    }

    public void AddMoney(int v = 1)
    {
        money += v;
    }
}
