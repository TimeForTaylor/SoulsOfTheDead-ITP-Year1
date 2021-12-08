using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreAdding : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameMaster.instance.AddScore();
            Destroy(gameObject);
        }
    }
}
