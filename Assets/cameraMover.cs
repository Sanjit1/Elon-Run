using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMover : MonoBehaviour
{
    public Transform target;

    void FixedUpdate()
    {
        Vector3 newPosition = target.position;
        newPosition.z = -50;
        newPosition.x = newPosition.x + 6.23f;
        newPosition.y = newPosition.y + 1.03f;
        transform.position = newPosition;
    }

    
}
