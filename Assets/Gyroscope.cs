using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gyroscope : MonoBehaviour
{
    public Rigidbody2D body;
    float dirX;
    float moveSpeed = 15f;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.acceleration.x * moveSpeed;
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -50f, 50f),transform.position.y);
    }

    void FixedUpdate()
    {
        body.velocity = new Vector2(dirX, 0f);
    }
}
