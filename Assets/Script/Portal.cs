using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    private GameMaster gm;
    public GameObject PortalUI;

    private void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        //Debug.Log("hello");
    }

    void Update()
    {
        if (gm.gameFinished)
        {
            PortalUI.SetActive(true);
        }
        else
        {
            PortalUI.SetActive(false);
        }
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && gm.gameFinished)
        {
            Debug.Log("collided");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            
        }
    }
    
    
}
