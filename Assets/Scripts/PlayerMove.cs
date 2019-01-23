using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMove : MonoBehaviour
{
    public float speed = 2f;
    public float maxY = 2.25f;

    private Rigidbody2D rb2d;
    
    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        var vel = rb2d.velocity;
        if (Input.GetKey(KeyCode.UpArrow)) {
            vel.y = speed;
        }
        else if (Input.GetKey(KeyCode.DownArrow)) {
            vel.y = -speed;
        }
        else {
            vel.y = 0;
        }
        
        rb2d.velocity = vel;

        var pos = transform.position;
        
        Mathf.Clamp(pos.y, -maxY,maxY);
        transform.position = pos;
    }
}
