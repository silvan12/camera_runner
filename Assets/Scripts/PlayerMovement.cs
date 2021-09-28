using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 10f;

    private void Start()
    {

    }

    void Update()
    {
        float xMovement = Input.GetAxisRaw("Horizontal");
        float yMovement = Input.GetAxis("Vertical"); // jump/duck

        transform.position += new Vector3(xMovement, 0, 0) * (Time.deltaTime * movementSpeed);
    }
}