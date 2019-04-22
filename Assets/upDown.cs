using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upDown : MonoBehaviour
{
    bool upOrDown = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 posit = transform.position;
        if (upOrDown)
        {
            posit.y += 0.1f;
            if (posit.y > 7.5) upOrDown = false;
        } else 
        {
            posit.y -= 0.1f;
            if (posit.y < 2.5) upOrDown = true;
        }
        transform.position = posit;
    }
}
