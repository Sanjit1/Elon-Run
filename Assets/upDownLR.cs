using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upDownLR : MonoBehaviour
{
    public int direction = 1;
    // 1 U 2 L 3 D 4 R 
    public int topRightY = 12;
    public int topLeftX = 22;
    public int bottomLeftY = 4;
    public int BottomRightX = 34;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Vector2 posit = transform.position;
        if (direction == 1)
        {
            posit.y += 0.1f;
            if (posit.y > topRightY) direction++;
        }
        else if (direction == 2)
        {
            posit.x -= 0.1f;
            if (posit.x < topLeftX) direction++;
        }
        else if (direction == 3)
        {
            posit.y -= 0.1f;
            if (posit.y < bottomLeftY) direction++;
        }
        else if (direction == 4)
        {
            posit.x += 0.1f;
            if (posit.x > BottomRightX) direction = 1;
        }
        transform.position = posit;
    }
}
