using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldGenerator : MonoBehaviour
{
    public static GameObject LastRoad { get; private set; }
    public GameObject[] road;
    private void Start()
    {
        LastRoad = road[2];
    }

    private void Update()
    {
        foreach (var r in road)
        {
            //Debug.Log(r + " " + r.transform.position);
            if (r.transform.position.x > LastRoad.transform.position.x)
            {
                LastRoad = r;
            }
        }
    }
}