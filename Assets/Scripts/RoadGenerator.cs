using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class RoadGenerator : MonoBehaviour
{
    public GameObject prevRoad;
    private GameObject LastRoad { get; set; }
    public GameObject frontWheel;
    public GameObject coin;
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
        RoadItemSpawn(LastRoad); 
        //RoadItemSpawn(LastRoad); 
        prevRoad.transform.position = LastRoad.transform.position + new Vector3(35, 0, 0);
    }
    
    private void RoadItemSpawn(GameObject obj)
    {
        var spawnLoc = new Vector3(Random.Range(0, 35), 1.5f, Random.Range(-10, 10));
        var coinSpawn = Instantiate(coin, spawnLoc, Quaternion.identity);
        coinSpawn.transform.SetParent(obj.transform, false);
        //coinSpawn.transform.position = spawnLoc;
    }
}
