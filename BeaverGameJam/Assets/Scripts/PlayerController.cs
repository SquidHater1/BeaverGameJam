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
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetKey(KeyCode.Space);
        rb.velocity = new Vector2(horizontalInput * moveSpeed, rb.velocity.y);
        if (verticalInput)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
        }
    }
}
