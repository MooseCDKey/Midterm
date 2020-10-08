using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public CharacterController controller;

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

        onGround = Physics.CheckSphere(CheckG.position, gDist, groundMask);

        if (onGround)
        {
            Debug.Log("isOnGround");
        }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * travel * Time.deltaTime);

         if (Input.GetKeyDown(KeyCode.Space) && controller.isGrounded)
         {
             Debug.Log("hasJumped");
             velocity.y = Mathf.Sqrt(JumpH * -2 * gravity);
         }
        


        if (Input.GetKey(KeyCode.LeftShift))
        {
            controller.Move(move * travelF * Time.deltaTime);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }
}
