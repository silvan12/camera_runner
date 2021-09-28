using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 10f;
    public float jumpSpeed = 300f;
    public Rigidbody rb;
    void Update()
    {
        float xMovement = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(xMovement, 0, 0) * (Time.deltaTime * movementSpeed);
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(Vector3.up * jumpSpeed);
        }
    }

    // FixedUpdate should be used for physics 
    private void FixedUpdate()
    {
        
    }
}