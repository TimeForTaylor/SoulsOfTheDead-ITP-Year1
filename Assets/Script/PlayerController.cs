using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;

    public float speed = 10f;
    
    private GameMaster gm;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        gm.lastCheckPointPos = Vector2.zero;
        transform.position = gm.lastCheckPointPos;
    }

    private void FixedUpdate()
    {
        
        float moveX = Input.GetAxis("Horizontal");
        float directionX = Mathf.Sign(moveX);
        float moveY = Input.GetAxis("Vertical");
        float directionY = Mathf.Sign(moveY);

        if (moveX != 0f)
        {
            Vector2 localScaleX = transform.localScale;
            localScaleX.x = directionX;
            transform.localScale = localScaleX;
        }

        Vector2 velocityX = rb.velocity;
        velocityX.x = moveX * speed;
        rb.velocity = velocityX;
        
        Vector2 velocityY = rb.velocity;
        velocityY.y = moveY * speed;
        rb.velocity = velocityY;
    }
}
