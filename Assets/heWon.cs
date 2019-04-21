using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heWon : MonoBehaviour
{
    public Collider2D muskColider;
    public Transform muskTransform;
    public Rigidbody2D musk;
    public Transform tesla;
    public Camera cam;

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
        newPosition.y = 80;
        transform.position = newPosition;
        if (piece == muskColider)
        {
            muskTransform.position = newPosition;
            newPosition.y = 100;
            tesla.position = newPosition;
            cam.GetComponent<cameraMover>().gameOn = false;
            musk.AddForce(new Vector2(0f, -100));
        }
    }
}