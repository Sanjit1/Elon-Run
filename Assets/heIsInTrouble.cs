using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heIsInTrouble : MonoBehaviour
{
    public Collider2D muskColider;
    public Transform muskTransform;
    public Camera cam;
    public Transform me;

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
        newPosition.y = 67.5f;
        transform.position = newPosition;
        if (piece == muskColider)
        {
            cam.GetComponent<cameraMover>().gameOn = false;
            muskTransform.position = newPosition;
            newPosition.y = 200;
            me.position = newPosition;
        }
    }
}

