using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMover : MonoBehaviour
{
    public Joystick joystick;

    public mover controller;
    public float horizontalMove = 0f;
    public bool jump = false;
    public bool crouch = false;
    public float runSpeed = 40f;
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        // Uncomment for webgl

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }

        if (Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.IPhonePlayer)
        {
            Debug.Log("phone");

        }


    }

    void FixedUpdate()
    {
        // Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }

    void moveWithButton(int horizontal, int vertical)
    {
        horizontalMove = horizontal * runSpeed;
        if(vertical == 1)
        {
            crouch = false;
            jump = true;
        }
        if (vertical == -1)
        {
            crouch = true;
        }
    }
}
 