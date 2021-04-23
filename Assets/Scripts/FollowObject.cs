using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowObject : MonoBehaviour
{
    public GameObject toFollow;
    public bool lockX;
    public bool lockY;
    public bool lockZ;
    private Vector3 _newPos;
    public Vector3 offset;

    private void Update()
    {
        _newPos = toFollow.transform.position;
        if (lockX)
        {
            _newPos.x = transform.position.x;
        }
        if (lockY)
        {
            _newPos.y = transform.position.y;
        }
        if (lockZ)
        {
            _newPos.z = transform.position.z;
        }
        transform.position = _newPos + offset;
    }
}
