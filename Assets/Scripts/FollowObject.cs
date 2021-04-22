using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowObject : MonoBehaviour
{
    public GameObject toFollow;
    public Vector3 offset;

    private void Update()
    {
        transform.position = toFollow.transform.position + offset;
    }
}
