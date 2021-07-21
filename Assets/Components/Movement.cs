using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 30f;

    void Update()
    {
        if (this.enabled == true)
        {
                    if (Input.GetKey("left shift"))
        {
            speed = 60f;
        }
        else
        {
            speed = 30f;
        }
        
            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");

            Vector3 move = transform.right * x + transform.forward * z;

            controller.Move(move * speed * Time.deltaTime);
        }
    }
}
