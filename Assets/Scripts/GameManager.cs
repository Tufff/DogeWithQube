using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    GameObject canvas;
    Transform playerTransform;

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

        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
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
        playerTransform.position = new Vector3(1.7f, 2f, playerTransform.position.z);
    }

    public void AddMoney(int v = 1)
    {
        money += v;
    }

    public void RemoveMoney(int v = 0)
    {
        money -= v;
    }
}
