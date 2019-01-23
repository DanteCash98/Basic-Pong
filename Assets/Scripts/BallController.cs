using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        Invoke("BallStart",3);
    }
    
    private void OnCollisionEnter2D (Collision2D coll) {
        if (!coll.collider.CompareTag("Player")) return;
        Vector2 vel;
        vel.x = rb2d.velocity.x;
        vel.y = (rb2d.velocity.y / 2) + (coll.collider.attachedRigidbody.velocity.y / 3);
        rb2d.velocity = vel;
    }
    
    public void RestartGame(){
        ResetBall();
        Invoke("BallStart", 1);
    }
    
    public void ReverseDirection()
    {
        rb2d.velocity = new Vector2(rb2d.velocity.x,-rb2d.velocity.y);
    }

    public void ResetBall(){
        rb2d.velocity = Vector2.zero;
        transform.position = Vector2.zero;
    }

    public void BallStart()
    {
        float rand = Random.Range(0, 2);
        rb2d.AddForce((rand < 1) ? new Vector2(-15, -15) : new Vector2(15, -15));
    }

}
