using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    public float playerSpeed = 5f;

    void Update()
    {
        float playerInput = Input.GetAxis("Vertical");

        Vector2 newPosition = transform.position + new Vector3(0f, playerInput * playerSpeed * Time.deltaTime, 0f);

        transform.position = newPosition;
    }
}
