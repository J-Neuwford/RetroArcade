using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMovement : MonoBehaviour
{

    public float ballSpeed = 5.0f;
    private Vector2 ballVelocity;

    void Start()
    {
        ballVelocity = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized * ballSpeed;
    }

    void Update()
    {
        transform.Translate(ballVelocity * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        ballVelocity = Vector2.Reflect(ballVelocity, collision.contacts[0].normal);
    }
}
