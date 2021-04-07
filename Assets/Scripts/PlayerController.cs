using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public float turnSpeed = 5.0f;
    private float horizontalInput { get; set; }
    private float verticalInput { get; set; }

    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * (Time.deltaTime * speed * verticalInput) );
        transform.Rotate(Vector3.up, (Time.deltaTime * turnSpeed * horizontalInput) );
    }
}
