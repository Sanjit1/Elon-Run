using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pacer : MonoBehaviour
{
    public bool teslaToldYou = false;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (teslaToldYou)
        {
            Vector2 pos = transform.position;
            pos.x -= 0.05f;
            if (pos.x > 4)
            {
                transform.position = pos;
            }
        }
    }

    public void placeFalcon()
    {
        Vector2 pos = transform.position;
        pos.x = 82;
        transform.position = pos;
    }
   
}
