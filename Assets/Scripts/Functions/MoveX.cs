using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveX: MonoBehaviour
{

    // Add force to rb if its speed is smaller than maxSpeed
    public void Physics(Rigidbody2D rb, float force, float maxSpeed)
    {
        if (Mathf.Abs(rb.velocity.x) < maxSpeed)
        {
            rb.AddForce(Vector2.right * force);
        }
        else
        {
            var dir = rb.velocity.x / Mathf.Abs(rb.velocity.x);
            rb.velocity = new Vector2(dir * maxSpeed, rb.velocity.y);
        }
    }

    private void SetVolocity(float speed)
    {

    }

    public void Graphics(SpriteRenderer sprRen, float dir)
    {
        if (dir > 0) { sprRen.flipX = false; }
        else if (dir < 0) { sprRen.flipX = true; }
    }
}
