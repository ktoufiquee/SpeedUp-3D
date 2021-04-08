using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public Transform centerOfMass;
    public float motorTorque = 100f;
    public float maxSteer = 20f;

    private float Steer { get; set; }
    private float Throttle { get; set; }
    
    private Rigidbody _rigidbody;
    private WheelController[] _wheels;
    private void Start()
    {
        _wheels = GetComponentsInChildren<WheelController>();
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.centerOfMass = centerOfMass.localPosition;
    }

    private void Update()
    {
        Steer = Input.GetAxis("Horizontal");
        Throttle = Input.GetAxis("Vertical");

        foreach (var wheel in _wheels)
        {
            wheel.SteerAngle = Steer * maxSteer;
            wheel.Torque = Throttle * motorTorque;
        }

    }
}
