using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DodgePointCollision : MonoBehaviour
{
    public Transform dp;
    public int DodgeThis=0;
    void Dodge()
    {
        DodgeThis=1;
    }
    private void OnTriggerEnter(Collider CollisionInfo)
    {
        if (CollisionInfo.tag == "Obstacle")
        {
            Dodge();
           
        }
    }


}
