﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cameraMover : MonoBehaviour
{
    public bool gameOn;
    public Transform target;
    public bool won = false;

     
    
    void FixedUpdate()
    {
        Vector3 newPosition = target.position;
        newPosition.z = -50;
        newPosition.y = newPosition.y + 3.03f;
        if (gameOn)
        {
           /* if ((target.position.y>-3.2 && target.position.y < 0.4)||(target.position.y > 9.9 && target.position.y <13.75))
            {
                newPosition.x = newPosition.x + 6.23f;
            } else
            {
                newPosition.x = newPosition.x - 6.23f;
            }
            */
            newPosition.y = newPosition.y - 2;
        }
        else
        {

            if (won)
            {
                if (Input.GetButtonDown("L2"))
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                }
            }
        }
        if (Input.GetButtonDown("Restart"))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        transform.position = newPosition;
    }

    
}
