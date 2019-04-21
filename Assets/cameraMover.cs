using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMover : MonoBehaviour
{
    public bool gameOn;
    public Transform target;

    void FixedUpdate()
    {
        Vector3 newPosition = target.position;
        newPosition.z = -50;
        newPosition.y = newPosition.y + 2.03f;
        if (gameOn)
        {
            newPosition.x = newPosition.x + 6.23f;
            newPosition.y = newPosition.y - 2;
        }
        transform.position = newPosition;
    }

    
}
