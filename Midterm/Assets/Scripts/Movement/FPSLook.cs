using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//The First Person Controls
//Mainly effects Main Camera
public class FPSLook : MonoBehaviour
{
    public float mouseSense = 110f; //sensitivity of mouse independant of framerate

    public Transform playerBody; //Makes the player capsule First Person

    float rotationX = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; //Locks cursor to center of screen for easier movement
       
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSense * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSense * Time.deltaTime;

        //Input from mouse to determine whether to go left or right
        rotationX -= mouseY;

        rotationX = Mathf.Clamp(rotationX, -90f, 90f);

        transform.localRotation = Quaternion.Euler(rotationX, 0f, 0f);

     

        playerBody.Rotate(Vector3.up * mouseX); //ability to look up
    }
}
