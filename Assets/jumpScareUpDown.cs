using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpScareUpDown : MonoBehaviour
{
    public bool upOrDown = true;
    public bool keepItGoing = false;
    public float dSpeed;
    public float uSpeed;
    public float top;
    public float bottom;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (keepItGoing)
        {

            Vector2 posit = transform.position;
            if (upOrDown)
            {
                posit.y += uSpeed;
                if (posit.y > top) upOrDown = false;
            }
            else
            {
                posit.y -= dSpeed;
                if (posit.y < bottom) upOrDown = true;
            }
            transform.position = posit;
        }

    }
}