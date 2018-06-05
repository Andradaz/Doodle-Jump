using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dissapear : MonoBehaviour {

    public GameObject platform;
    public float jumpForce = 11f;
    // Use this for initialization
    void OnCollisionEnter2D(Collision2D collision)
    {
        Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            if (collision.relativeVelocity.y <= 0f)
            {
                Vector2 velocity = rb.velocity;
                velocity.y = jumpForce;
                rb.velocity = velocity;
                platform.SetActive(false);
            }

            
        }
    }

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
