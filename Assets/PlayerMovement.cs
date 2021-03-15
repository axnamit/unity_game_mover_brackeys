using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour

{
    public Rigidbody rb;
    public float forceApplied = 800f;
    public float sideways = 800f;

    void FixedUpdate()
    {
        //

        rb.AddForce(0, 0, forceApplied * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sideways*Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideways*Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
       

    }
}
