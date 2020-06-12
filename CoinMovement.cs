using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CoinMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float ForwardForce = -2000f;
   
    private void OnTriggerEnter(Collider CollisionInfo)
    {
        if (CollisionInfo.name== "Player" || CollisionInfo.name == "PlayerAI")
        {
          
            Destroy(gameObject);
            FindObjectOfType<Score>().CoinScore();
        }
    }

    void Update()
    {
        rb.AddForce(0, 0, ForwardForce * Time.deltaTime);
        if (transform.position.z < -20f)
            Destroy(gameObject);
    }
}
