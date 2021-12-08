using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishedText : MonoBehaviour
{
    private GameMaster gm;
    public GameObject finishedText;
    private void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
    }
    
    void Update()
    {
        if (gm.gameFinished)
        {
            finishedText.SetActive(true);
        }
        else
        {
            finishedText.SetActive(false);
        }
    }
}
