using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class Movement2 : MonoBehaviour
{
    public float speed = 50f;

    // Start is called before the first frame update
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();

        //transform.Rotate(0, Input.GetAxis("Horizontal") * speedRotate, 0);

        Vector3 forward = transform.InverseTransformDirection(Vector3.forward);
        float Speed2 = speed * Input.GetAxis("Vertical");
        controller.SimpleMove(forward * Speed2);

        Vector3 right = transform.InverseTransformDirection(Vector3.right);
        float Speed3 = speed * Input.GetAxis("Horizontal");
        controller.SimpleMove(right * Speed3);

        Vector3 left = transform.InverseTransformDirection(Vector3.left);
        float Speed4 = speed * Input.GetAxis("Horizontal");
        controller.SimpleMove(left * Speed4);

        Vector3 back = transform.InverseTransformDirection(Vector3.back);
        float Speed5 = speed * Input.GetAxis("Vertical");
        controller.SimpleMove(back * Speed5);
    }
}
