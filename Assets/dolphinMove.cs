using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dolphinMove : MonoBehaviour
{
    // Start is called before the first frame update
    public mover controller;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        controller.Move(40 * Time.fixedDeltaTime, false, false);
    }
}
