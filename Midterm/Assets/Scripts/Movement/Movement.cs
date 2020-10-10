using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public CharacterController controller;

    //statistics for character movements
    public float travel = 15f;
    public float travelF = 20f;
    public float JumpH = 5f;
    public float gravity = -9.81f;

    public Transform CheckG;
    public float gDist = 0.5f;
    public LayerMask groundMask;
    bool onGround;
    Vector3 velocity;


    // Update is called once per frame
    void Update()
    {

        //basic ground check
        onGround = Physics.CheckSphere(CheckG.position, gDist, groundMask);

        if (onGround)
        {
            Debug.Log("isOnGround");
        }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * travel * Time.deltaTime);

        //if right click is clicked and player is on ground, player will jump
         if (Input.GetKeyDown(KeyCode.Mouse1) && controller.isGrounded)
         {
             Debug.Log("hasJumped");
             velocity.y = Mathf.Sqrt(JumpH * -2 * gravity);
         }
        

         //basic sprint, if lshift is held down
         //character will go faster
        if (Input.GetKey(KeyCode.LeftShift))
        {
            controller.Move(move * travelF * Time.deltaTime);
        }

        //how velocity is handled in gravity
        velocity.y += gravity * Time.deltaTime;
         
        controller.Move(velocity * Time.deltaTime);
    }
}
