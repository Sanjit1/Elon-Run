﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevatorTesla : MonoBehaviour
{
    public Transform musk;
    public GameObject rocket;
    public GameObject dolphinsRocket;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D piece)
    {
        Vector2 pos = transform.position;
        pos.x = 81;
        pos.y = 30;
        musk.position = pos;
        rocket.GetComponent<Pacer>().teslaToldYou = true;
        rocket.GetComponent<Pacer>().placeFalcon();
        dolphinsRocket.GetComponent<Pacer>().teslaToldYou = true;
        dolphinsRocket.GetComponent<Pacer>().placeFalcon();

    }
}
