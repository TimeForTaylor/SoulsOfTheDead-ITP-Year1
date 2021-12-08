using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    public static GameMaster instance;
    public Vector2 lastCheckPointPos;
    public HUDController hudController;
    public int playerScore;
    public bool gameFinished = false;

    void Awake()
    {
        
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad((instance));
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        if (playerScore == 20)
        {
            gameFinished = true;
        }
    }

    public void AddScore()
    {
        playerScore++;
        // add some score
        //Debug.Log(playerScore);
        hudController.SetScore("Souls Collected " + playerScore + "/20");
    }
}
