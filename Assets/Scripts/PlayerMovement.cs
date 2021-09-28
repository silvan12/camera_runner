using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 10f;
    public float jumpSpeed = 300f;
    public float distanceToGround = 0.5f;
    
    public Rigidbody rb;

    void Update()
    {
        float xMovement = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(xMovement, 0, 0) * (Time.deltaTime * movementSpeed);
        
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W) && IsGrounded())
        {
            rb.AddForce(Vector3.up * jumpSpeed);
        }
    }

    bool IsGrounded()
    // Shoot a raycast right below the player
    // If it hits 
    {
        return Physics.Raycast(transform.position, Vector3.down, distanceToGround, LayerMask.GetMask("Ground"));

    }
}