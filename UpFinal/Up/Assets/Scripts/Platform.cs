using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour {

    // Use this for initialization

    public float jumpForce = 11f;

    void OnCollisionEnter2D(Collision2D collision)
    {
        Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
        if(rb != null)
        {
            if (collision.relativeVelocity.y <= 0f)
            {
                Vector2 velocity = rb.velocity;
                velocity.y = jumpForce;
                rb.velocity = velocity;
            }
        }
    }

    // Update is called once per frame

}
