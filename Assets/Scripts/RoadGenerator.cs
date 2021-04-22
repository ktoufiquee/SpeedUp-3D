using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadGenerator : MonoBehaviour
{
    public GameObject prevRoad;
    private GameObject LastRoad { get; set; }
    public GameObject frontWheel;
    private void Start()
    {
        
    }

    private void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Collider>().name != "Vehicle")
        {
            return;
        }
        LastRoad = WorldGenerator.LastRoad;
        Debug.Log(LastRoad);
        prevRoad.transform.position = LastRoad.transform.position + new Vector3(35, 0, 0);
    }
}
