using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Goal : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball"))
        {
            gameManager.ScorePoint(false);
        }
    }
}
