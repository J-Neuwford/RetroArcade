using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject ball;
    public GameObject player1;
    public GameObject player2;
    public int winningScore = 5;

    private int player1Score;
    private int player2Score;

    void Start()
    {
        player1Score = 0;
        player2Score = 0;
    }

    public void ScorePoint(bool player1Scored)
    {
        if (player1Scored)
        {
            player1Score++;
            Debug.Log("Player 1 Score: " +  player1Score);
        }
        else
        {
            player2Score++;
            Debug.Log("Player 2 Score: " + player2Score);
        }

        if (player1Score >= winningScore || player2Score >= winningScore)
        {
            EndGame();
        }
        else
        {
            ball.transform.position = Vector3.zero;
            ball.GetComponent<Ball>().Start();
        }
    }

    void EndGame()
    {
        Debug.Log("Game Over!"); 
    }
}


