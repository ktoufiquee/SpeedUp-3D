using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelController : MonoBehaviour
{
    public bool steer;
    public bool invertSteer;
    public bool power;

    public float SteerAngle { get; set; }
    public float Torque { get; set; }

    private WheelCollider _wheelCollider;
    private Transform _wheelTransform;
    
    private void Start()
    {
        _wheelCollider = GetComponentInChildren<WheelCollider>();
        _wheelTransform = GetComponentInChildren<MeshRenderer>().GetComponent<Transform>();
    }

    private void Update()
    {
        // var brake = Input.GetKey(KeyCode.Space);
        // if(brake && power) return;
        _wheelCollider.GetWorldPose(out var pos, out var rot);
        _wheelTransform.position = pos;
        _wheelTransform.rotation = rot;
    }

    private void FixedUpdate()
    {
        //var brake = Input.GetKey(KeyCode.Space);
        if (steer)
        {
            _wheelCollider.steerAngle = SteerAngle * (invertSteer ? -1 : 1);
        }
        // if (brake && power)
        // {
        //     _wheelCollider.brakeTorque = 500.0f;
        // }
        // else
        // {
        //     _wheelCollider.brakeTorque = 0;
        // }
        if (power)
        {
            _wheelCollider.motorTorque = Torque;
        }
        
    }
}
