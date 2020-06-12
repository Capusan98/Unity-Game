using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rbp;


    public float SidewaysForce = 500f;

    // Update is called once per frame
    void FixedUpdate()
    {
       // rb.AddForce(0, 0, ForwardForce * Time.deltaTime);
        if(Input.GetKey("d"))
        {
            rbp.AddForce(SidewaysForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rbp.AddForce(-SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (transform.position.y < -10)
            FindObjectOfType<GameManager>().EndGame();

    }
}
