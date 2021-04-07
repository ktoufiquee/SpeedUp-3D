using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public GameObject player;
    private Vector3 camOffset { get; set; }

    private void Start()
    {
        camOffset = transform.position;
    }

    private void Update()
    {
        transform.position = player.transform.position + camOffset;
    }
}
