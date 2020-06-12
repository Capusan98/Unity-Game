using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float ForwardForce = -2000f;
    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0, 0, ForwardForce * Time.deltaTime);
        if (transform.position.z < -20f)
            Destroy(gameObject);
    }
}
