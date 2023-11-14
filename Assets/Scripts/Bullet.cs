using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Interactions;

public class Bullet : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;

    }

    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "hitter")
        {
            Destroy(gameObject);
        }

    }

 
}
