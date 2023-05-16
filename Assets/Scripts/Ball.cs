using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float ballSpeed = 5f;
    private Vector2 ballVelocity;

    public void Start()
    {
        ballVelocity = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized * ballSpeed;
    }

    private void Update()
    {
        transform.Translate(ballVelocity * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        ballVelocity = Vector2.Reflect(ballVelocity, collision.contacts[0].normal);
    }
}
