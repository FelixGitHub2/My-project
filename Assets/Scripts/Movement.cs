using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    Rigidbody2D rigidbody;
    [SerializeField] float speed;

    [SerializeField] float jumpForce;

    [SerializeField] LayerMask groundLayer;


    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float xMovement = Input.GetAxisRaw("Horizontal");
        float yMovement = Input.GetAxisRaw("Vertical");
        Vector2 movement = new Vector2(xMovement, yMovement).normalized * speed * Time.deltaTime;
        transform.Translate(movement);

        if (Input.GetKeyDown(KeyCode.W))
        {
            rigidbody.velocity = Vector2.up * jumpForce;
        }

    

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "jermabullet")
        {
            SceneManager.LoadScene(7);
        }

    }
    


}
