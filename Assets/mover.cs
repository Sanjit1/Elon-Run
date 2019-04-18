using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    
    private bool beingHandled = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    private void Update()
    {
        Vector3 pos = transform.position;
        Quaternion rot = transform.rotation;
        rot.z = 0;
        if (Input.GetKeyDown(KeyCode.W)) { pos.y = pos.y + 3.4f; }
        if (Input.GetKeyDown(KeyCode.A)) { pos.x = pos.x - 2f; }
        if (Input.GetKeyDown(KeyCode.S)) { pos.y = pos.y - 2.5f; }
        if (Input.GetKeyDown(KeyCode.D)) { pos.x = pos.x + 2f; }
        transform.position = pos;
        transform.rotation = rot;

    }

    

}
