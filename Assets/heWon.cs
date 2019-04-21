using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heWon : MonoBehaviour
{
    public Collider2D muskColider;
    public Transform muskTransform;
    public Transform tesla; 

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D piece)
    {


        Vector3 newPosition = muskTransform.position;
        newPosition.x = 70f;
        newPosition.y = 80f;
        transform.position = newPosition;
        if (piece == muskColider)
        {
            muskTransform.position = newPosition;
            newPosition.y = 75;
            tesla.position = newPosition;
        }
    }
}