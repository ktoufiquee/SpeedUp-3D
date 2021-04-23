using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void Awake()
    {
        Destroy(gameObject, 30);
    }

    private void OnTriggerEnter(Collider other)
    {
        // var sName = other.GetComponent<Collider>().name;
        // Debug.Log(sName);
        // if (sName != "Lower" || sName != "Upper")
        // {
        //     return;
        // }
        ScoreController.Score++;
        Destroy(gameObject);
        //Debug.Log(ScoreController.Score);
    }
}
