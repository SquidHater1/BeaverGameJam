using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float jumpHeight = 5.0f;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    

    private Rigidbody2D rb;
    private float horizontalInput;
    private bool verticalInput;
    private bool grounded;


    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
    }


    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetKey(KeyCode.Space);
        rb.velocity = new Vector2(horizontalInput * moveSpeed, rb.velocity.y);
        if (verticalInput && grounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
        }
    }
}
