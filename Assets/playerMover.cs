using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMover : MonoBehaviour
{ 

    public mover controller;
    public float horizontalMove = 0f;
    public bool jump = false;
    public bool crouch = false;
    public float runSpeed = 40f;
    public float mobileRunSpeed = 40f;
    public Rigidbody2D musk;
    public UnityEngine.UI.Button right;
    public UnityEngine.UI.Button left;

    public void RightLeft(float horizontal)
    {
        musk.AddForce(new Vector2(Mathf.RoundToInt(2*(horizontal-0.5f)) * mobileRunSpeed, 0f));
        Debug.Log(horizontal);
    }

    public void UpDown(int vertical)
    {
        if (vertical == 1)
        {
            crouch = false;
            jump = true;
        }
        if (vertical == -1)
        {
            crouch = true;
        }
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

         horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        // Uncomment for webgl
        // horizontalMove = Joystick.Horizontal * runSpeed;

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

    
}
 