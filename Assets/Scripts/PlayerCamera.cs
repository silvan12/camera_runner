using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public Camera topCamera;
    public Camera sideCamera;
    void Start()
    {
        topCamera.enabled = true;
        sideCamera.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            topCamera.enabled = !topCamera.enabled;
            sideCamera.enabled = !sideCamera.enabled;
        }
    }
}
