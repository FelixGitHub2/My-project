using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingBullet : MonoBehaviour
{
    public float speed = 1.0f;
    private Rigidbody2D rb;

    private Vector2 screenBounds;
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, -speed);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "stupidfloor")
        {
            Destroy(gameObject);
        }

    }
}
