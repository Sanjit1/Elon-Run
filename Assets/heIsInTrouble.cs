﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heIsInTrouble : MonoBehaviour
{
    public Collider2D muskColider;
    public Transform muskTransform;

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
        newPosition.x = 15f;
        newPosition.y = -38f;
        transform.position = newPosition;
        if (piece == muskColider)
        {
            // He is in trouble
            muskTransform.position = newPosition;
        }
    }
}

