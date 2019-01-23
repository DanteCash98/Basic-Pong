using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
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
        if (Input.GetKey(KeyCode.W)) {
            vel.y = speed;
        }
        else if (Input.GetKey(KeyCode.S)) {
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
